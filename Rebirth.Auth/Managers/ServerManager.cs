using Rebirth.Auth.Datas;
using Rebirth.Common.Extensions;
using Rebirth.Common.Protocol.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rebirth.Auth.Managers
{
    public class ServerManager : DataManager<ServerManager>
    {
        private List<Server> _servers;
        private List<WorldCharacter> _worldCharacters;

        public void Init()
        {
            _servers = Starter.Database.Fetch<Server>("SELECT * FROM servers");
            _worldCharacters = Starter.Database.Fetch<WorldCharacter>("SELECT * FROM worlds_characters");
        }

        public GameServerInformations[] GetListInformation(int accountId)
        {
            return _servers.Select(x => x.GetGameServerInformations(accountId)).ToArray();
        }

        public Server GetServer(int id)
        {
            return _servers.FirstOrDefault(x => x.Id == id);
        }

        public Server GetServer(string name)
        {
            return _servers.FirstOrDefault(x => x.Name == name);
        }

        public WorldCharacter GetWorldCharacter(int accountId, int serverId)
        {
            return _worldCharacters.FirstOrDefault(x => x.AccountId == accountId && x.ServerId == serverId);
        }

        public uint[] GetServerAccount(int accountId)
        {
            return _worldCharacters.FindAll(x => x.AccountId == accountId).Select(x => (uint)x.Id).ToArray();
        }

        public void AddCharacter(int accId, int serverId)
        {
            var character = GetWorldCharacter(accId, serverId);
            if (character != null)
            {
                character.Count += 1;
                Starter.Database.Update(character);
            }
            else
            {
                var newChar = new WorldCharacter()
                {
                    AccountId = accId,
                    ServerId = serverId,
                    Count = 1
                };
                newChar.Id = (int)Convert.ToUInt64(Starter.Database.Insert("worlds_characters", "Id", true, newChar));
                _worldCharacters.Add(newChar);
            }
        }

        public void RemoveCharacter(int accId, int serverId)
        {
            var character = GetWorldCharacter(accId, serverId);
            if (character != null)
                character.Count -= 1;
        }
    }
}
