using Rebirth.Common.Protocol.Data;
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
    public abstract class Zaap : AbstractInteractive
    {
        public abstract uint[] ActionId
        {
            get;
        }

        public abstract uint CellId
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
                var dialog = new ZaapDialog(character, this);
                dialog.Open();
                InteractiveFrame.SendInteractiveUsedMessage(character.Client, (uint)Identifier, ActionId[0], 0);
                Waypoint[] wp = InteractiveManager.Instance.GetAllWaypointExcept(character.Infos.MapId);
                character.Client.Send(new ZaapListMessage(0, (from x in wp
                                                              select (int)x.mapId).ToArray(), (from x in wp
                                                                                               select x.subAreaId).ToArray(), new uint[wp.Count()], new sbyte[wp.Count()], 503316480));
            }
        }
    }
}
