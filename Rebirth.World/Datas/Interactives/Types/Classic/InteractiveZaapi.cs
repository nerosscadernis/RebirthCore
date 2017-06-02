using Rebirth.Common.Protocol.Types;
using Rebirth.World.Datas.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rebirth.World.Datas.Interactives.Types.Classic
{
    public class InteractiveZaapi : Zaapi
    {
        public override int Type { get { return 106; } }
        public override uint[] ActionId { get { return new uint[] { 157 }; } }

        public override int Identifier { get; set; }

        public InteractiveZaapi(int Identifier, uint CellId, int SubArea, int MapId, bool IsOnMap)
        {
            this.Identifier = Identifier;
            base.CellId = CellId;
            base.SubArea = SubArea;
            base.MapId = MapId;
            base.IsOnMap = IsOnMap;
        }

        public override InteractiveElement GetInteractiveElement(Character character)
        {
            return new InteractiveElement(Identifier, Type, (from x in ActionId
                                                             select new InteractiveElementSkill(x, (int)x)).ToArray(), new InteractiveElementSkill[0], true);
        }

    }
}
