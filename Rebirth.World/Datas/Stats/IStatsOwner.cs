using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Game.Characters.Stats
{
    public interface IStatsOwner
    {
        StatsFields Stats
        {
            get;
        }
    }
}
