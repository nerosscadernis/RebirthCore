using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Datas.Characters;
using Rebirth.World.Datas.Maps;
using Rebirth.World.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rebirth.World.Datas.Interactives.Types
{
    public class InteractiveAtelier : AbstractInteractive
    {
        public int Type { get; }
        public uint[] ActionId { get; }
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
        public int Identifier { get; set; }

        public uint CellId
        {
            get;
            set;
        }

        public InteractiveAtelier(int Identifier, uint CellId, int Type, uint[] ActionId, int MapId)
        {
            this.Identifier = Identifier;
            this.CellId = CellId;
            this.Type = Type;
            this.ActionId = ActionId;
            this.MapId = MapId;
        }

        public InteractiveElement GetInteractiveElement(Character character)
        {
            return new InteractiveElement(Identifier, Type, (from x in ActionId
                                                             select new InteractiveElementSkill(x, (int)x)).ToArray(), new InteractiveElementSkill[0], true);
        }

        public void Use(Character character, uint skill)
        {
            //if (ActionId.Contains(skill) && character.Jobs.ContainsSkill(skill) || skill == 102)
            //{
            //    MapTemplate map = MapManager.Instance.GetMapById(MapId);
            //    if (map != null)
            //    {
            //        map.Send(new InteractiveUsedMessage((uint)character.Id, (uint)Identifier, skill, 0, false));
            //    }
            //    var dialog = new CraftDialog(character, (int)skill);
            //    dialog.Open();
            //}
            //else
            //{
                character.Client.Send(new InteractiveUseErrorMessage((uint)Identifier, skill));
            //}
        }
    }
}
