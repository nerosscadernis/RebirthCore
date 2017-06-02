using Rebirth.Common.Protocol.Types;
using Rebirth.World.Datas.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rebirth.World.Datas.Interactives.Types.Classic
{
    public class InteractiveZaap : Zaap
    {
        public override int Type { get { return 16; } }
        public override uint[] ActionId { get { return new uint[] { 114 }; } }

        public override int Identifier { get; set; }

        public override uint CellId
        {
            get;
            set;
        }

        public InteractiveZaap(int Identifier, uint CellId)
        {
            this.Identifier = Identifier;
            this.CellId = CellId;
        }

        public override InteractiveElement GetInteractiveElement(Character character)
        {
            return new InteractiveElement(Identifier, Type, (from x in ActionId
                                                             select new InteractiveElementSkill(x, (int)x)).ToArray(), new InteractiveElementSkill[0], true);
        }

    }
}
