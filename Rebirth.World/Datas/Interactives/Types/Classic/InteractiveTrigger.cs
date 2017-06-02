using Rebirth.Common.Protocol.Types;
using Rebirth.World.Datas.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rebirth.World.Datas.Interactives.Types.Classic
{
    public class InteractiveTrigger : AbstractInteractive
    {
        public int Type { get { return -1; } }
        public uint[] ActionId { get { return new uint[] { 339 }; } }

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

        public InteractiveTrigger(int Identifier, uint cellId)
        {
            this.Identifier = Identifier;
            this.CellId = cellId;
        }

        public InteractiveElement GetInteractiveElement(Character character)
        {
            return new InteractiveElement(Identifier, Type, (from x in ActionId
                                                             select new InteractiveElementSkill(x, 0)).ToArray(), new InteractiveElementSkill[0], true);
        }

        public void Use(Character character, uint skill)
        { }
    }
}
