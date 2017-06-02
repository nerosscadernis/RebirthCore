using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Game.Characters.Stats
{
    public class StatsData
    {
        protected StatsFormulasHandler m_formulas;
        protected int ValueBase;
        protected int ValueAdditionnal;
        protected int ValueEquiped;
        protected int ValueAlignGiftBonus;
        protected int ValueContextModif;
        private int? m_limit;
        protected int ValueGiven;
        public event Action<StatsData, int> Modified;
        public IStatsOwner Owner
        {
            get;
            set;
        }
        public PlayerFields Name
        {
            get;
            protected set;
        }
        public virtual int Base
        {
            get
            {
                return (this.m_formulas != null) ? ((int)this.m_formulas(this.Owner) + this.ValueBase) : this.ValueBase;
            }
            set
            {
                this.ValueBase = value;
                this.OnModified();
            }
        }
        public virtual int Equiped
        {
            get
            {
                return this.ValueEquiped;
            }
            set
            {
                this.ValueEquiped = value;
                this.OnModified();
            }
        }
        public virtual int Alignement
        {
            get
            {
                return this.ValueAlignGiftBonus;
            }
            set
            {
                this.ValueAlignGiftBonus = value;
                this.OnModified();
            }
        }
        public virtual int Additionnal
        {
            get
            {
                return this.Given;
            }
            set
            {
                this.Given = value;
                this.OnModified();
            }
        }
        public virtual int Context
        {
            get
            {
                return this.ValueContextModif;
            }
            set
            {
                this.ValueContextModif = value;
                this.OnModified();
            }
        }
        public virtual int Total
        {
            get
            {
                int num = this.Base + this.Equiped;
                if (this.Limit.HasValue && num > this.Limit.Value)
                {
                    num = this.Limit.Value;
                }
                if (Name == PlayerFields.NeutralResistPercent || Name == PlayerFields.EarthResistPercent || Name == PlayerFields.WaterResistPercent || Name == PlayerFields.AirResistPercent || Name == PlayerFields.FireResistPercent)
                {
                    return num + this.Additionnal + this.Context > 50 ? 50 : num + this.Additionnal + this.Context;
                }
                else
                    return num + this.Additionnal + this.Context;
            }
        }
        public virtual int TotalSafe
        {
            get
            {
                int total = this.Total;
                return (total > 0) ? total : 0;
            }
        }
        public virtual int? Limit
        {
            get
            {
                return this.m_limit;
            }
            set
            {
                this.m_limit = value;
                this.OnModified();
            }
        }
        public virtual int Given
        {
            get
            {
                return this.ValueGiven;
            }
            set
            {
                this.ValueGiven = value;
                this.OnModified();
            }
        }
        public StatsData(IStatsOwner owner, PlayerFields name, int valueBase, StatsFormulasHandler formulas = null)
        {
            this.ValueBase = valueBase;
            this.m_formulas = formulas;
            this.Name = name;
            this.Owner = owner;
        }
        public StatsData(IStatsOwner owner, PlayerFields name, int valueBase, int limit)
        {
            this.ValueBase = valueBase;
            this.m_limit = new int?(limit);
            this.Name = name;
            this.Owner = owner;
        }
        protected virtual void OnModified()
        {
            Action<StatsData, int> modified = this.Modified;
            if (modified != null)
            {
                modified(this, this.Total);
            }
        }
        public static int operator +(int i1, StatsData s1)
        {
            return i1 + s1.Total;
        }
        public static int operator +(StatsData s1, StatsData s2)
        {
            return s1.Total + s2.Total;
        }
        public static int operator -(int i1, StatsData s1)
        {
            return i1 - s1.Total;
        }
        public static int operator -(StatsData s1, StatsData s2)
        {
            return s1.Total - s2.Total;
        }
        public static int operator *(int i1, StatsData s1)
        {
            return i1 * s1.Total;
        }
        public static int operator *(StatsData s1, StatsData s2)
        {
            return s1.Total * s2.Total;
        }
        public static double operator /(StatsData s1, double d1)
        {
            return (double)s1.Total / d1;
        }
        public static double operator /(StatsData s1, StatsData s2)
        {
            return (double)s1.Total / (double)s2.Total;
        }
        public static implicit operator CharacterBaseCharacteristic(StatsData s1)
        {
            return new CharacterBaseCharacteristic((int)((s1.Base > 32767) ? 32767 : s1.Base), (int)((s1.Additionnal > 32767) ? 32767 : s1.Additionnal),(int)((s1.Equiped > 32767) ? 32767 : s1.Equiped), (int)((s1.Alignement > 32767) ? 32767 : s1.Alignement), (int)((s1.Context > 32767) ? 32767 : s1.Context));
        }
        public override string ToString()
        {
            return string.Format("{0}({1}+{2}+{3})", new object[]
            {
                this.Total,
                this.Base,
                this.Equiped,
                this.Context
            });
        }
        public virtual StatsData Clone()
        {
            return (StatsData)base.MemberwiseClone();
        }
        public StatsData CloneAndChangeOwner(IStatsOwner owner)
        {
            StatsData statsData = (StatsData)base.MemberwiseClone();
            statsData.Owner = owner;
            return statsData;
        }
    }
}
