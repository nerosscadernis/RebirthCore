using Rebirth.Common.Extensions;
using Rebirth.Common.Utils;
using Rebirth.World.Datas.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Rebirth.World.Managers
{
    public class CharacterManager : DataManager<CharacterManager>
    {
        public readonly Regex _nameCheckerRegex = new Regex("^[A-Z][a-z]{2,9}(?:-[A-Z][a-z]{2,9}|[a-z]{1,10})$", RegexOptions.Compiled);

        private List<Character> _characters;

        public void Init()
        {
            _characters = new List<Character>();

            var records = Starter.Database.Fetch<CharacterRecord>("SELECT * FROM characters");
            foreach (var record in records)
            {
                _characters.Add(new Character(record));
            }
        }

        public List<Character> GetList(int accId)
        {
            return _characters.FindAll(x => x.Infos.AccountId == accId);
        }

        public Character GetCharacter(double charId)
        {
            return _characters.FirstOrDefault(x => x.Infos.Id == charId);
        }

        public bool NameExist(string name)
        {
            return _characters.Any(x => x.Infos.Name.ToLower() == name.ToLower());
        }

        public void AddCharacter(Character character)
        {
            dynamic newChar = Starter.Database.Insert("characters", "Id", true, character.GetRecord());
            character.Infos.Id = newChar;
            _characters.Add(character);
        }

        public void DeleteCharacter(Character character)
        {
            _characters.Remove(character);
            Starter.Database.Delete(character.GetRecord());
        }
    }
}
