using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Datas.Characters;
using Rebirth.World.Datas.Interactives.Dialogs;
using Rebirth.World.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rebirth.World.Datas.Interactives.Types
{
    public class InteractiveDefault : AbstractInteractive
    {
        public int Type { get { return -1; } }
        public uint[] ActionId { get { return new uint[] { 184 }; } }

        public int Identifier { get; set; }

        public uint CellId
        {
            get;
            set;
        }
        public bool IsOnMap
        {
            get;
            set;
        }
        public InteractiveDefault(int Identifier, uint cellId, bool onMap)
        {
            this.Identifier = Identifier;
            this.CellId = cellId;
            IsOnMap = onMap;
        }

        public InteractiveElement GetInteractiveElement(Character character)
        {
            return new InteractiveElement(Identifier, Type, (from x in ActionId
                                                             select new InteractiveElementSkill(x, 0)).ToArray(), new InteractiveElementSkill[0], IsOnMap);
        }

        public void Use(Character character, uint skill)
        {
            InteractiveDatas datas = InteractiveManager.Instance.GetDatasById(Identifier);
            if (datas != null)
            {
                switch (datas.Type)
                {
                    case Common.Protocol.Enums.InteractiveTypeEnum.Teleportation:
                        switch (Identifier)
                        {
                            default:
                                character.Teleport(datas.Data1, (short)datas.Data2);
                                break;
                        }
                        break;
                    case Common.Protocol.Enums.InteractiveTypeEnum.Book:
                        character.Activity = new BookDialog(character, (uint)datas.Data1);
                        break;
                    case Common.Protocol.Enums.InteractiveTypeEnum.Message:
                        character.Client.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_ENTITY_TALK, (uint)datas.Data1, new string[0]));
                        break;
                    case Common.Protocol.Enums.InteractiveTypeEnum.Wanted:
                        break;
                    //case InteractiveTypeEnum.GuildPannel:
                    //    if (character.Inventory.GetItemByTemplateId(1575) != null && character.Guild == null)
                    //    {
                    //        character.Client.Send(new GuildCreationStartedMessage());
                    //    }
                    //    break;
                    //case InteractiveTypeEnum.AlliancePannel:
                    //    if (character.Inventory.GetItemByTemplateId(14290) != null && character.Guild != null)
                    //    {
                    //        character.Client.Send(new AllianceCreationStartedMessage());
                    //    }
                    //    break;
                    default:
                        break;
                }
                character.Client.Send(new InteractiveUsedMessage((uint)character.Infos.Id, (uint)Identifier, ActionId[0], 0, false));
            }
            else
            {
                if (character.Client.Account.Role > CharacterRoleEnum.Player)
                    character.Client.Send(new ChatServerMessage((sbyte)ChatActivableChannelsEnum.PSEUDO_CHANNEL_INFO, "Interactive = " + Identifier, 0, "", 0, "Server", 0));
                character.Client.Send(new InteractiveUseErrorMessage((uint)Identifier, ActionId[0]));
            }
        }
    }
}
