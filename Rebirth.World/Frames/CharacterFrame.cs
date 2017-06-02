using Rebirth.Common.Dispatcher;
using Rebirth.Common.Extensions;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.IO;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Thread;
using Rebirth.World.Datas.Characters;
using Rebirth.World.Game.Characters.Stats;
using Rebirth.World.Managers;
using Rebirth.World.Network;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Rebirth.World.Frames
{
    public class CharacterFrame
    {
        [MessageHandler(CharactersListRequestMessage.Id)]
        private void HandleCharactersListRequestMessage(Client client, CharactersListRequestMessage msg)
        {
            List<int> list = new List<int>();
            list.Add((int)BreedEnum.Iop);
            list.Add((int)BreedEnum.Feca);
            list.Add((int)BreedEnum.Cra);
            list.Add((int)BreedEnum.Sacrieur);
            list.Add((int)BreedEnum.Enutrof);
            list.Add((int)BreedEnum.Zobal);
            list.Add((int)BreedEnum.Eniripsa);
            list.Add((int)BreedEnum.Ecaflip);
            list.Add((int)BreedEnum.Sram);
            list.Add((int)BreedEnum.Roublard);
            list.Add((int)BreedEnum.Eliotrope);
            list.Add((int)BreedEnum.Osamodas);
            list.Add((int)BreedEnum.Huppermage);
            list.Add((int)BreedEnum.Sadida);
            list.Add((int)BreedEnum.Xelor);
            list.Add((int)BreedEnum.Pandawa);
            list.Add((int)BreedEnum.Steamer);
            list.Add((int)BreedEnum.Ouginak);

            int lol = 0;
            foreach (var t in list)
                lol += (int)Math.Pow(2, t - 1);

            client.Send(new AccountCapabilitiesMessage(false, true, client.Account.Id, (uint)lol, (uint)lol, 1));
            client.Send(new CharactersListMessage(CharacterManager.Instance.GetList(client.Account.Id).OrderByDescending(x => x.Infos.LastConnexion)
                .Select(x => x.GetCharacterBaseInformations()).ToArray(), false));
        }

        const string consonne = "qwrtpsdfghjklzxcvbnm";
        const string voyelle = "aeiouy";

        [MessageHandler(CharacterNameSuggestionRequestMessage.Id)]
        private void HandleCharacterNameSuggestionRequestMessage(Client client, CharacterNameSuggestionRequestMessage msg)
        {
            var rdn = new AsyncRandom();
            string result = string.Empty;
            switch (rdn.Next(0, 3))
            {
                case 1:
                    result += consonne[rdn.Next(0, consonne.Length)].ToString().ToUpper();
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += consonne[rdn.Next(0, consonne.Length)];
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += consonne[rdn.Next(0, consonne.Length)];
                    break;
                case 2:
                    result += consonne[rdn.Next(0, consonne.Length)].ToString().ToUpper();
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += consonne[rdn.Next(0, consonne.Length)];
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += consonne[rdn.Next(0, consonne.Length)];
                    break;
                case 3:
                    result += voyelle[rdn.Next(0, consonne.Length)].ToString().ToUpper();
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += consonne[rdn.Next(0, voyelle.Length)];
                    result += consonne[rdn.Next(0, consonne.Length)];
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += consonne[rdn.Next(0, consonne.Length)];
                    break;
                default:
                    result += consonne[rdn.Next(0, consonne.Length)].ToString().ToUpper();
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += consonne[rdn.Next(0, consonne.Length)];
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += consonne[rdn.Next(0, consonne.Length)];
                    result += "-";
                    result += consonne[rdn.Next(0, consonne.Length)].ToString().ToUpper();
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += consonne[rdn.Next(0, consonne.Length)];
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += consonne[rdn.Next(0, consonne.Length)];
                    break;
            }
            client.Send(new CharacterNameSuggestionSuccessMessage(result));
        }

        [MessageHandler(CharacterCreationRequestMessage.Id)]
        private void HandleCharacterCreationRequestMessage(Client client, CharacterCreationRequestMessage msg)
        {
            var breed = ObjectDataManager.Get<Breed>(msg.breed, true);
            if(breed == null)
            {
                client.Send(new CharacterCreationResultMessage((sbyte)CharacterCreationResultEnum.ERR_NOT_ALLOWED));
                return;
            }
            if (!CharacterManager.Instance._nameCheckerRegex.IsMatch(msg.name))
            {
                client.Send(new CharacterCreationResultMessage((sbyte)CharacterCreationResultEnum.ERR_INVALID_NAME));
                return;
            }

            var character = new Character()
            {
                Infos = new CharacterInfos()
                {
                    AccountId = client.Account.Id,
                    ActiveFinisher = 0,
                    DeathCount = 0,
                    CellId = 370,
                    Direction = DirectionsEnum.DIRECTION_SOUTH_EAST,
                    ActiveOrnament = 0,
                    ActiveTitle = 0,
                    Breed = breed.id,
                    Experience = 0,
                    Finishers = new List<short>(),
                    LastLevel = 1,
                    MapId = 154010883,
                    Name = msg.name,
                    Nickname = client.Account.Nickname,
                    Ornaments = new List<short>(),
                    Sex = Convert.ToByte(msg.sex),
                    Titles = new List<short>(),
                    Zaaps = new List<short>(),
                    ZaapSave = 84674563,
                    LastConnexion = (long)DateTime.Now.DateTimeToUnixTimestamp(),
                    SpellsPoint = 0,
                    StatsPoint = 0
                },
                Look = Look.Parse(msg.sex ? breed.femaleLook : breed.maleLook),
            };
            character.Stats = new StatsFields(character);
            character.Stats.Initialize();

            int num = 0;
            List<uint> defaultColors = msg.sex ? breed.femaleColors : breed.maleColors;
            foreach (int current in msg.colors)
            {
                num++;
                character.Look.UpdateColor(num, (current == -1) ? (int)defaultColors[num - 1] : current);
            }

            short[] skins = ObjectDataManager.Get<Head>((int)msg.cosmeticId).skins.FromCSV<short>(",");
            for (int i = 0; i < skins.Length; i++)
            {
                short skin = skins[i];
                character.Look.AddSkin(skin);
            }

            CharacterManager.Instance.AddCharacter(character);
            Starter.AuthClient.Send(new CreateCharacterMessage(client.Account.Id));
            client.Send(new CharacterCreationResultMessage((sbyte)CharacterCreationResultEnum.OK));
            client.Send(new BasicNoOperationMessage());
            client.Send(new CharactersListMessage(CharacterManager.Instance.GetList(client.Account.Id).OrderByDescending(x => x.Infos.LastConnexion)
                .Select(x => x.GetCharacterBaseInformations()).ToArray(), false));
        }

        [MessageHandler(CharacterDeletionRequestMessage.Id)]
        private void HandleCharacterDeletionRequestMessage(Client client, CharacterDeletionRequestMessage msg)
        {
            var character = CharacterManager.Instance.GetCharacter(msg.characterId);
            if(character == null)
            {
                client.Send(new CharacterDeletionErrorMessage((sbyte)CharacterDeletionErrorEnum.DEL_ERR_NO_REASON));
                return;
            }
            if(client.Account.Id != character.Infos.AccountId)
            {
                client.Send(new CharacterDeletionErrorMessage((sbyte)CharacterDeletionErrorEnum.DEL_ERR_NO_REASON));
                return;
            }
            else
            {
                if(character.Infos.Level >= 20 && client.Account.SecretAnswer != msg.secretAnswerHash)
                {
                    client.Send(new CharacterDeletionErrorMessage((sbyte)CharacterDeletionErrorEnum.DEL_ERR_BAD_SECRET_ANSWER));
                    return;
                }

                CharacterManager.Instance.DeleteCharacter(character);
            }
        }

        [MessageHandler(CharacterSelectionMessage.Id)]
        private void HandleCharacterSelectionMessage(Client client, CharacterSelectionMessage msg)
        {
            var character = CharacterManager.Instance.GetCharacter(msg.id);
            if (character != null)
            {
                character.Infos.LastConnexion = (long)DateTime.Now.DateTimeToUnixTimestamp();
                client.Character = character;
                client.Send(new NotificationListMessage(new int[0]));
                client.Send(new CharacterSelectedSuccessMessage(client.Character.GetCharacterBaseInformations(), false));
                character.Client = client;
                WorldManager.Instance.Enter(character);
            }
            else
                client.Send(new CharacterSelectedErrorMessage());
        }
    }
}
