using Rebirth.Common.Protocol.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Game.Characters.Stats
{
    public class StatsAP : StatsData
    {
        public short Used
        {
            get;
            set;
        }
        public int TotalMax
        {
            get
            {
                return base.Total;
            }
        }
        public override int Total
        {
            get
            {
                return this.TotalMax - (int)this.Used;
            }
        }
        public StatsAP(IStatsOwner owner, int valueBase) : base(owner, PlayerFields.AP, valueBase, null)
        {
        }
        public StatsAP(IStatsOwner owner, int valueBase, int limit) : base(owner, PlayerFields.AP, valueBase, limit)
        {
        }
    }
}
