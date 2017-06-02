using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Datas.Characters;
using Rebirth.World.Datas.Interactives.Dialogs;
using Rebirth.World.Frames;
using Rebirth.World.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rebirth.World.Datas.Interactives.Types
{
    public abstract class Zaapi : AbstractInteractive
    {
        public abstract uint[] ActionId
        {
            get;
        }

        public uint CellId
        {
            get;
            set;
        }

        public int SubArea
        {
            get;
            set;
        }

        public int MapId
        {
            get;
            set;
        }

        public bool IsOnMap
        {
            get;
            set;
        }

        public abstract int Identifier
        {
            get;
            set;
        }

        public abstract int Type
        {
            get;
        }

        public abstract InteractiveElement GetInteractiveElement(Character character);

        public void Use(Character character, uint skill)
        {
            if (ActionId.Contains(skill))
            {
                var dialog = new ZaapiDialog(character, this);
                dialog.Open();
                InteractiveFrame.SendInteractiveUsedMessage(character.Client, (uint)Identifier, ActionId[0], 0);
                List<Zaapi> wp = MapManager.Instance.GetZaapiBySub(SubArea);
                character.Client.Send(new TeleportDestinationsListMessage(1, (from x in wp
                                                                              select (int)x.MapId).ToArray(), (from x in wp
                                                                                                               select (uint)x.SubArea).ToArray(), new uint[wp.Count()], new sbyte[0]));
            }
        }
    }
}
