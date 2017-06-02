using Rebirth.Common.IO;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Game.Characters.Stats
{
    public class StatsFields
    {
        public static int MPLimit = 6;
        public static int APLimit = 12;
        public static int RangeLimit = 6;
        private static readonly StatsFormulasHandler FormulasChanceDependant = (IStatsOwner owner) => (short)(owner.Stats[PlayerFields.Chance] / 10.0);
        private static readonly StatsFormulasHandler FormulasWisdomDependant = (IStatsOwner owner) => (short)(owner.Stats[PlayerFields.Wisdom] / 10.0);
        private static readonly StatsFormulasHandler FormulasAgilityDependant = (IStatsOwner owner) => (short)(owner.Stats[PlayerFields.Agility] / 10.0);
        public int Effect_AddDamageBonus;

        #region Properties
        public System.Collections.Generic.Dictionary<PlayerFields, StatsData> Fields
        {
            get;
            private set;
        }
        public IStatsOwner Owner
        {
            get;
            private set;
        }
        public StatsFields(IStatsOwner owner)
        {
            this.Owner = owner;
        }
        public int GetTotal(PlayerFields name)
        {
            StatsData statsData = this[name];
            return (statsData == null) ? 0 : statsData.Total;
        }
        #endregion

        #region StatsCustom
        public StatsHealth Health
        {
            get
            {
                return this[PlayerFields.Health] as StatsHealth;
            }
        }
        public StatsAP AP
        {
            get
            {
                return this[PlayerFields.AP] as StatsAP;
            }
        }
        public StatsMP MP
        {
            get
            {
                return this[PlayerFields.MP] as StatsMP;
            }
        }
        public StatsData Vitality
        {
            get
            {
                return this[PlayerFields.Vitality];
            }
        }
        public StatsData Strength
        {
            get
            {
                return this[PlayerFields.Strength];
            }
        }
        public StatsData Wisdom
        {
            get
            {
                return this[PlayerFields.Wisdom];
            }
        }
        public StatsData Chance
        {
            get
            {
                return this[PlayerFields.Chance];
            }
        }
        public StatsData Agility
        {
            get
            {
                return this[PlayerFields.Agility];
            }
        }
        public StatsData Intelligence
        {
            get
            {
                return this[PlayerFields.Intelligence];
            }
        }
        public StatsData Initiative
        {
            get
            {
                return this[PlayerFields.Initiative];
            }
        }
        public StatsData Prospecting
        {
            get
            {
                return this[PlayerFields.Prospecting];
            }
        }
        public StatsData NeutralResistPercent
        {
            get
            {
                return this[PlayerFields.NeutralResistPercent];
            }
        }
        public StatsData EarthResistPercent
        {
            get
            {
                return this[PlayerFields.EarthResistPercent];
            }
        }
        public StatsData WaterResistPercent
        {
            get
            {
                return this[PlayerFields.WaterResistPercent];
            }
        }
        public StatsData AirResistPercent
        {
            get
            {
                return this[PlayerFields.AirResistPercent];
            }
        }
        public StatsData FireResistPercent
        {
            get
            {
                return this[PlayerFields.FireResistPercent];
            }
        }
        public StatsData SummonLimit
        {
            get
            {
                return this[PlayerFields.SummonLimit];
            }
        }
        public StatsData DamageBonus
        {
            get
            {
                return this[PlayerFields.DamageBonus];
            }
        }
        public StatsData ShieldTest
        {
            get
            {
                return this[PlayerFields.Shield];
            }
        }
        public StatsData PushDamageBonus
        {
            get
            {
                return this[PlayerFields.PushDamageBonus];
            }
        }
        public StatsData PushDamageReduction
        {
            get
            {
                return this[PlayerFields.PushDamageReduction];
            }
        }
        public StatsData CriticalDamage
        {
            get
            {
                return this[PlayerFields.CriticalDamageBonus];
            }
        }
        public StatsData CriticalDamageReduction
        {
            get
            {
                return this[PlayerFields.CriticalDamageReduction];
            }
        }
        public StatsData Range
        {
            get
            {
                return this[PlayerFields.Range];
            }
        }
        public StatsData MPAttack
        {
            get
            {
                return this[PlayerFields.MPAttack];
            }
        }
        public StatsData APAttack
        {
            get
            {
                return this[PlayerFields.APAttack];
            }
        }
        public StatsData DodgeMPProbability
        {
            get
            {
                return this[PlayerFields.DodgeMPProbability];
            }
        }
        public StatsData DodgeAPProbability
        {
            get
            {
                return this[PlayerFields.DodgeAPProbability];
            }
        }
        public StatsData this[PlayerFields name]
        {
            get
            {
                StatsData statsData;
                return this.Fields.TryGetValue(name, out statsData) ? statsData : null;
            }
        }
        #endregion

        public void ForceResetStat()
        {
            foreach (var item in Fields.Values)
            {
                item.Context = 0;
            }
        }

        #region Init
        public void Initialize(byte[] record)
        {
            var reader = new BigEndianReader(record);

            SpellBoosts = new StatsSpellBoost() { Owner = Owner };
            this.Fields = new System.Collections.Generic.Dictionary<PlayerFields, StatsData>();
            this.Fields.Add(PlayerFields.Initiative, new StatsInitiative(this.Owner, 0));
            this.Fields.Add(PlayerFields.Prospecting, new StatsData(this.Owner, PlayerFields.Prospecting, reader.ReadShort(), StatsFields.FormulasChanceDependant));
            this.Fields.Add(PlayerFields.AP, new StatsAP(this.Owner, reader.ReadShort(), StatsFields.APLimit));
            this.Fields.Add(PlayerFields.MP, new StatsMP(this.Owner, reader.ReadShort(), StatsFields.MPLimit));
            this.Fields.Add(PlayerFields.Strength, new StatsData(this.Owner, PlayerFields.Strength, reader.ReadShort(), null));
            this.Fields.Add(PlayerFields.Vitality, new StatsData(this.Owner, PlayerFields.Vitality, reader.ReadShort(), null));
            this.Fields.Add(PlayerFields.Health, new StatsHealth(this.Owner, reader.ReadShort(), reader.ReadShort()));
            this.Fields.Add(PlayerFields.Wisdom, new StatsData(this.Owner, PlayerFields.Wisdom, reader.ReadShort(), null));
            this.Fields.Add(PlayerFields.Chance, new StatsData(this.Owner, PlayerFields.Chance, reader.ReadShort(), null));
            this.Fields.Add(PlayerFields.Agility, new StatsData(this.Owner, PlayerFields.Agility, reader.ReadShort(), null));
            this.Fields.Add(PlayerFields.Intelligence, new StatsData(this.Owner, PlayerFields.Intelligence, reader.ReadShort(), null));
            this.Fields.Add(PlayerFields.Range, new StatsData(this.Owner, PlayerFields.Range, 0, StatsFields.RangeLimit));
            this.Fields.Add(PlayerFields.SummonLimit, new StatsData(this.Owner, PlayerFields.SummonLimit, 1, null));
            this.Fields.Add(PlayerFields.DamageReflection, new StatsData(this.Owner, PlayerFields.DamageReflection, 0, null));
            this.Fields.Add(PlayerFields.CriticalHit, new StatsData(this.Owner, PlayerFields.CriticalHit, 0, null));
            this.Fields.Add(PlayerFields.CriticalMiss, new StatsData(this.Owner, PlayerFields.CriticalMiss, 0, null));
            this.Fields.Add(PlayerFields.HealBonus, new StatsData(this.Owner, PlayerFields.HealBonus, 0, null));
            this.Fields.Add(PlayerFields.DamageBonus, new StatsData(this.Owner, PlayerFields.DamageBonus, 0, null));
            this.Fields.Add(PlayerFields.WeaponDamageBonus, new StatsData(this.Owner, PlayerFields.WeaponDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.DamageBonusPercent, new StatsData(this.Owner, PlayerFields.DamageBonusPercent, 0, null));
            this.Fields.Add(PlayerFields.TrapBonus, new StatsData(this.Owner, PlayerFields.TrapBonus, 0, null));
            this.Fields.Add(PlayerFields.TrapBonusPercent, new StatsData(this.Owner, PlayerFields.TrapBonusPercent, 0, null));
            this.Fields.Add(PlayerFields.PermanentDamagePercent, new StatsData(this.Owner, PlayerFields.PermanentDamagePercent, 0, null));
            this.Fields.Add(PlayerFields.TackleBlock, new StatsData(this.Owner, PlayerFields.TackleBlock, 0, StatsFields.FormulasAgilityDependant));
            this.Fields.Add(PlayerFields.TackleEvade, new StatsData(this.Owner, PlayerFields.TackleEvade, 0, StatsFields.FormulasAgilityDependant));
            this.Fields.Add(PlayerFields.APAttack, new StatsData(this.Owner, PlayerFields.APAttack, 0, StatsFields.FormulasWisdomDependant));
            this.Fields.Add(PlayerFields.MPAttack, new StatsData(this.Owner, PlayerFields.MPAttack, 0, StatsFields.FormulasWisdomDependant));
            this.Fields.Add(PlayerFields.PushDamageBonus, new StatsData(this.Owner, PlayerFields.PushDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.CriticalDamageBonus, new StatsData(this.Owner, PlayerFields.CriticalDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.NeutralDamageBonus, new StatsData(this.Owner, PlayerFields.NeutralDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.EarthDamageBonus, new StatsData(this.Owner, PlayerFields.EarthDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.WaterDamageBonus, new StatsData(this.Owner, PlayerFields.WaterDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.AirDamageBonus, new StatsData(this.Owner, PlayerFields.AirDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.FireDamageBonus, new StatsData(this.Owner, PlayerFields.FireDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.DodgeAPProbability, new StatsData(this.Owner, PlayerFields.DodgeAPProbability, 0, StatsFields.FormulasWisdomDependant));
            this.Fields.Add(PlayerFields.DodgeMPProbability, new StatsData(this.Owner, PlayerFields.DodgeMPProbability, 0, StatsFields.FormulasWisdomDependant));
            this.Fields.Add(PlayerFields.NeutralResistPercent, new StatsData(this.Owner, PlayerFields.NeutralResistPercent, 0, null));
            this.Fields.Add(PlayerFields.EarthResistPercent, new StatsData(this.Owner, PlayerFields.EarthResistPercent, 0, null));
            this.Fields.Add(PlayerFields.WaterResistPercent, new StatsData(this.Owner, PlayerFields.WaterResistPercent, 0, null));
            this.Fields.Add(PlayerFields.AirResistPercent, new StatsData(this.Owner, PlayerFields.AirResistPercent, 0, null));
            this.Fields.Add(PlayerFields.FireResistPercent, new StatsData(this.Owner, PlayerFields.FireResistPercent, 0, null));
            this.Fields.Add(PlayerFields.NeutralElementReduction, new StatsData(this.Owner, PlayerFields.NeutralElementReduction, 0, null));
            this.Fields.Add(PlayerFields.EarthElementReduction, new StatsData(this.Owner, PlayerFields.EarthElementReduction, 0, null));
            this.Fields.Add(PlayerFields.WaterElementReduction, new StatsData(this.Owner, PlayerFields.WaterElementReduction, 0, null));
            this.Fields.Add(PlayerFields.AirElementReduction, new StatsData(this.Owner, PlayerFields.AirElementReduction, 0, null));
            this.Fields.Add(PlayerFields.FireElementReduction, new StatsData(this.Owner, PlayerFields.FireElementReduction, 0, null));
            this.Fields.Add(PlayerFields.PushDamageReduction, new StatsData(this.Owner, PlayerFields.PushDamageReduction, 0, null));
            this.Fields.Add(PlayerFields.CriticalDamageReduction, new StatsData(this.Owner, PlayerFields.CriticalDamageReduction, 0, null));
            this.Fields.Add(PlayerFields.PvpNeutralResistPercent, new StatsData(this.Owner, PlayerFields.PvpNeutralResistPercent, 0, null));
            this.Fields.Add(PlayerFields.PvpEarthResistPercent, new StatsData(this.Owner, PlayerFields.PvpEarthResistPercent, 0, null));
            this.Fields.Add(PlayerFields.PvpWaterResistPercent, new StatsData(this.Owner, PlayerFields.PvpWaterResistPercent, 0, null));
            this.Fields.Add(PlayerFields.PvpAirResistPercent, new StatsData(this.Owner, PlayerFields.PvpAirResistPercent, 0, null));
            this.Fields.Add(PlayerFields.PvpFireResistPercent, new StatsData(this.Owner, PlayerFields.PvpFireResistPercent, 0, null));
            this.Fields.Add(PlayerFields.PvpNeutralElementReduction, new StatsData(this.Owner, PlayerFields.PvpNeutralElementReduction, 0, null));
            this.Fields.Add(PlayerFields.PvpEarthElementReduction, new StatsData(this.Owner, PlayerFields.PvpEarthElementReduction, 0, null));
            this.Fields.Add(PlayerFields.PvpWaterElementReduction, new StatsData(this.Owner, PlayerFields.PvpWaterElementReduction, 0, null));
            this.Fields.Add(PlayerFields.PvpAirElementReduction, new StatsData(this.Owner, PlayerFields.PvpAirElementReduction, 0, null));
            this.Fields.Add(PlayerFields.PvpFireElementReduction, new StatsData(this.Owner, PlayerFields.PvpFireElementReduction, 0, null));
            this.Fields.Add(PlayerFields.GlobalDamageReduction, new StatsData(this.Owner, PlayerFields.GlobalDamageReduction, 0, null));
            this.Fields.Add(PlayerFields.DamageMultiplicator, new StatsData(this.Owner, PlayerFields.DamageMultiplicator, 0, null));
            this.Fields.Add(PlayerFields.PhysicalDamage, new StatsData(this.Owner, PlayerFields.PhysicalDamage, 0, null));
            this.Fields.Add(PlayerFields.MagicDamage, new StatsData(this.Owner, PlayerFields.MagicDamage, 0, null));
            this.Fields.Add(PlayerFields.PhysicalDamageReduction, new StatsData(this.Owner, PlayerFields.PhysicalDamageReduction, 0, null));
            this.Fields.Add(PlayerFields.MagicDamageReduction, new StatsData(this.Owner, PlayerFields.MagicDamageReduction, 0, null));
            this.Fields.Add(PlayerFields.WaterDamageArmor, new StatsData(this.Owner, PlayerFields.WaterDamageArmor, 0, null));
            this.Fields.Add(PlayerFields.EarthDamageArmor, new StatsData(this.Owner, PlayerFields.EarthDamageArmor, 0, null));
            this.Fields.Add(PlayerFields.NeutralDamageArmor, new StatsData(this.Owner, PlayerFields.NeutralDamageArmor, 0, null));
            this.Fields.Add(PlayerFields.AirDamageArmor, new StatsData(this.Owner, PlayerFields.AirDamageArmor, 0, null));
            this.Fields.Add(PlayerFields.FireDamageArmor, new StatsData(this.Owner, PlayerFields.FireDamageArmor, 0, null));
            this.Fields.Add(PlayerFields.Erosion, new StatsData(this.Owner, PlayerFields.Erosion, 10, null));
            this.Fields.Add(PlayerFields.Shield, new StatsData(this.Owner, PlayerFields.Shield, 0, null));
            this.Fields.Add(PlayerFields.GlyphBonus, new StatsData(this.Owner, PlayerFields.GlyphBonus, 0, null));
            this.Fields.Add(PlayerFields.GlyphBonusPercent, new StatsData(this.Owner, PlayerFields.GlyphBonusPercent, 0, null));
            this.Fields.Add(PlayerFields.HealMultiplicator, new StatsData(this.Owner, PlayerFields.HealMultiplicator, 0, null));
            this.Fields.Add(PlayerFields.BonusPano, new StatsData(this.Owner, PlayerFields.BonusPano, 0, null));
            this.Fields.Add(PlayerFields.BombBonus, new StatsData(this.Owner, PlayerFields.BombBonus, 0, null));
            this.Fields.Add(PlayerFields.FinalDamage, new StatsData(this.Owner, PlayerFields.FinalDamage, 0, null));
        }

        public void Initialize()
        {
            SpellBoosts = new StatsSpellBoost() { Owner = Owner };
            this.Fields = new System.Collections.Generic.Dictionary<PlayerFields, StatsData>();
            this.Fields.Add(PlayerFields.Initiative, new StatsInitiative(this.Owner, 0));
            this.Fields.Add(PlayerFields.Prospecting, new StatsData(this.Owner, PlayerFields.Prospecting, 100, StatsFields.FormulasChanceDependant));
            this.Fields.Add(PlayerFields.AP, new StatsAP(this.Owner, 6, StatsFields.APLimit));
            this.Fields.Add(PlayerFields.MP, new StatsMP(this.Owner, 3, StatsFields.MPLimit));
            this.Fields.Add(PlayerFields.Strength, new StatsData(this.Owner, PlayerFields.Strength, 0, null));
            this.Fields.Add(PlayerFields.Vitality, new StatsData(this.Owner, PlayerFields.Vitality, 0, null));
            this.Fields.Add(PlayerFields.Health, new StatsHealth(this.Owner, 55, 0));
            this.Fields.Add(PlayerFields.Wisdom, new StatsData(this.Owner, PlayerFields.Wisdom, 0, null));
            this.Fields.Add(PlayerFields.Chance, new StatsData(this.Owner, PlayerFields.Chance, 0, null));
            this.Fields.Add(PlayerFields.Agility, new StatsData(this.Owner, PlayerFields.Agility, 0, null));
            this.Fields.Add(PlayerFields.Intelligence, new StatsData(this.Owner, PlayerFields.Intelligence, 0, null));
            this.Fields.Add(PlayerFields.Range, new StatsData(this.Owner, PlayerFields.Range, 0, StatsFields.RangeLimit));
            this.Fields.Add(PlayerFields.SummonLimit, new StatsData(this.Owner, PlayerFields.SummonLimit, 1, null));
            this.Fields.Add(PlayerFields.DamageReflection, new StatsData(this.Owner, PlayerFields.DamageReflection, 0, null));
            this.Fields.Add(PlayerFields.CriticalHit, new StatsData(this.Owner, PlayerFields.CriticalHit, 0, null));
            this.Fields.Add(PlayerFields.CriticalMiss, new StatsData(this.Owner, PlayerFields.CriticalMiss, 0, null));
            this.Fields.Add(PlayerFields.HealBonus, new StatsData(this.Owner, PlayerFields.HealBonus, 0, null));
            this.Fields.Add(PlayerFields.DamageBonus, new StatsData(this.Owner, PlayerFields.DamageBonus, 0, null));
            this.Fields.Add(PlayerFields.WeaponDamageBonus, new StatsData(this.Owner, PlayerFields.WeaponDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.DamageBonusPercent, new StatsData(this.Owner, PlayerFields.DamageBonusPercent, 0, null));
            this.Fields.Add(PlayerFields.TrapBonus, new StatsData(this.Owner, PlayerFields.TrapBonus, 0, null));
            this.Fields.Add(PlayerFields.TrapBonusPercent, new StatsData(this.Owner, PlayerFields.TrapBonusPercent, 0, null));
            this.Fields.Add(PlayerFields.PermanentDamagePercent, new StatsData(this.Owner, PlayerFields.PermanentDamagePercent, 0, null));
            this.Fields.Add(PlayerFields.TackleBlock, new StatsData(this.Owner, PlayerFields.TackleBlock, 0, StatsFields.FormulasAgilityDependant));
            this.Fields.Add(PlayerFields.TackleEvade, new StatsData(this.Owner, PlayerFields.TackleEvade, 0, StatsFields.FormulasAgilityDependant));
            this.Fields.Add(PlayerFields.APAttack, new StatsData(this.Owner, PlayerFields.APAttack, 0, StatsFields.FormulasWisdomDependant));
            this.Fields.Add(PlayerFields.MPAttack, new StatsData(this.Owner, PlayerFields.MPAttack, 0, StatsFields.FormulasWisdomDependant));
            this.Fields.Add(PlayerFields.PushDamageBonus, new StatsData(this.Owner, PlayerFields.PushDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.CriticalDamageBonus, new StatsData(this.Owner, PlayerFields.CriticalDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.NeutralDamageBonus, new StatsData(this.Owner, PlayerFields.NeutralDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.EarthDamageBonus, new StatsData(this.Owner, PlayerFields.EarthDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.WaterDamageBonus, new StatsData(this.Owner, PlayerFields.WaterDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.AirDamageBonus, new StatsData(this.Owner, PlayerFields.AirDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.FireDamageBonus, new StatsData(this.Owner, PlayerFields.FireDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.DodgeAPProbability, new StatsData(this.Owner, PlayerFields.DodgeAPProbability, 0, StatsFields.FormulasWisdomDependant));
            this.Fields.Add(PlayerFields.DodgeMPProbability, new StatsData(this.Owner, PlayerFields.DodgeMPProbability, 0, StatsFields.FormulasWisdomDependant));
            this.Fields.Add(PlayerFields.NeutralResistPercent, new StatsData(this.Owner, PlayerFields.NeutralResistPercent, 0, null));
            this.Fields.Add(PlayerFields.EarthResistPercent, new StatsData(this.Owner, PlayerFields.EarthResistPercent, 0, null));
            this.Fields.Add(PlayerFields.WaterResistPercent, new StatsData(this.Owner, PlayerFields.WaterResistPercent, 0, null));
            this.Fields.Add(PlayerFields.AirResistPercent, new StatsData(this.Owner, PlayerFields.AirResistPercent, 0, null));
            this.Fields.Add(PlayerFields.FireResistPercent, new StatsData(this.Owner, PlayerFields.FireResistPercent, 0, null));
            this.Fields.Add(PlayerFields.NeutralElementReduction, new StatsData(this.Owner, PlayerFields.NeutralElementReduction, 0, null));
            this.Fields.Add(PlayerFields.EarthElementReduction, new StatsData(this.Owner, PlayerFields.EarthElementReduction, 0, null));
            this.Fields.Add(PlayerFields.WaterElementReduction, new StatsData(this.Owner, PlayerFields.WaterElementReduction, 0, null));
            this.Fields.Add(PlayerFields.AirElementReduction, new StatsData(this.Owner, PlayerFields.AirElementReduction, 0, null));
            this.Fields.Add(PlayerFields.FireElementReduction, new StatsData(this.Owner, PlayerFields.FireElementReduction, 0, null));
            this.Fields.Add(PlayerFields.PushDamageReduction, new StatsData(this.Owner, PlayerFields.PushDamageReduction, 0, null));
            this.Fields.Add(PlayerFields.CriticalDamageReduction, new StatsData(this.Owner, PlayerFields.CriticalDamageReduction, 0, null));
            this.Fields.Add(PlayerFields.PvpNeutralResistPercent, new StatsData(this.Owner, PlayerFields.PvpNeutralResistPercent, 0, null));
            this.Fields.Add(PlayerFields.PvpEarthResistPercent, new StatsData(this.Owner, PlayerFields.PvpEarthResistPercent, 0, null));
            this.Fields.Add(PlayerFields.PvpWaterResistPercent, new StatsData(this.Owner, PlayerFields.PvpWaterResistPercent, 0, null));
            this.Fields.Add(PlayerFields.PvpAirResistPercent, new StatsData(this.Owner, PlayerFields.PvpAirResistPercent, 0, null));
            this.Fields.Add(PlayerFields.PvpFireResistPercent, new StatsData(this.Owner, PlayerFields.PvpFireResistPercent, 0, null));
            this.Fields.Add(PlayerFields.PvpNeutralElementReduction, new StatsData(this.Owner, PlayerFields.PvpNeutralElementReduction, 0, null));
            this.Fields.Add(PlayerFields.PvpEarthElementReduction, new StatsData(this.Owner, PlayerFields.PvpEarthElementReduction, 0, null));
            this.Fields.Add(PlayerFields.PvpWaterElementReduction, new StatsData(this.Owner, PlayerFields.PvpWaterElementReduction, 0, null));
            this.Fields.Add(PlayerFields.PvpAirElementReduction, new StatsData(this.Owner, PlayerFields.PvpAirElementReduction, 0, null));
            this.Fields.Add(PlayerFields.PvpFireElementReduction, new StatsData(this.Owner, PlayerFields.PvpFireElementReduction, 0, null));
            this.Fields.Add(PlayerFields.GlobalDamageReduction, new StatsData(this.Owner, PlayerFields.GlobalDamageReduction, 0, null));
            this.Fields.Add(PlayerFields.DamageMultiplicator, new StatsData(this.Owner, PlayerFields.DamageMultiplicator, 0, null));
            this.Fields.Add(PlayerFields.PhysicalDamage, new StatsData(this.Owner, PlayerFields.PhysicalDamage, 0, null));
            this.Fields.Add(PlayerFields.MagicDamage, new StatsData(this.Owner, PlayerFields.MagicDamage, 0, null));
            this.Fields.Add(PlayerFields.PhysicalDamageReduction, new StatsData(this.Owner, PlayerFields.PhysicalDamageReduction, 0, null));
            this.Fields.Add(PlayerFields.MagicDamageReduction, new StatsData(this.Owner, PlayerFields.MagicDamageReduction, 0, null));
            this.Fields.Add(PlayerFields.WaterDamageArmor, new StatsData(this.Owner, PlayerFields.WaterDamageArmor, 0, null));
            this.Fields.Add(PlayerFields.EarthDamageArmor, new StatsData(this.Owner, PlayerFields.EarthDamageArmor, 0, null));
            this.Fields.Add(PlayerFields.NeutralDamageArmor, new StatsData(this.Owner, PlayerFields.NeutralDamageArmor, 0, null));
            this.Fields.Add(PlayerFields.AirDamageArmor, new StatsData(this.Owner, PlayerFields.AirDamageArmor, 0, null));
            this.Fields.Add(PlayerFields.FireDamageArmor, new StatsData(this.Owner, PlayerFields.FireDamageArmor, 0, null));
            this.Fields.Add(PlayerFields.Erosion, new StatsData(this.Owner, PlayerFields.Erosion, 10, null));
            this.Fields.Add(PlayerFields.Shield, new StatsData(this.Owner, PlayerFields.Shield, 0, null));
            this.Fields.Add(PlayerFields.GlyphBonus, new StatsData(this.Owner, PlayerFields.GlyphBonus, 0, null));
            this.Fields.Add(PlayerFields.GlyphBonusPercent, new StatsData(this.Owner, PlayerFields.GlyphBonusPercent, 0, null));
            this.Fields.Add(PlayerFields.HealMultiplicator, new StatsData(this.Owner, PlayerFields.HealMultiplicator, 0, null));
            this.Fields.Add(PlayerFields.BonusPano, new StatsData(this.Owner, PlayerFields.BonusPano, 0, null));
            this.Fields.Add(PlayerFields.BombBonus, new StatsData(this.Owner, PlayerFields.BombBonus, 0, null));
            this.Fields.Add(PlayerFields.FinalDamage, new StatsData(this.Owner, PlayerFields.FinalDamage, 0, null));
        }

        public byte[] GetDatas()
        {
            var writer = new BigEndianWriter();
            writer.WriteShort((short)Prospecting.Base);
            writer.WriteShort((short)AP.Base);
            writer.WriteShort((short)MP.Base);
            writer.WriteShort((short)Strength.Base);
            writer.WriteShort((short)Vitality.Base);
            writer.WriteShort((short)Health.Base);
            writer.WriteShort((short)Health.DamageTaken);
            writer.WriteShort((short)Wisdom.Base);
            writer.WriteShort((short)Chance.Base);
            writer.WriteShort((short)Agility.Base);
            writer.WriteShort((short)Intelligence.Base);
            return writer.Data;
        }

        public void Initialize(MonsterGrade record)
        {
            SpellBoosts = new StatsSpellBoost() { Owner = Owner };
            this.Fields = new System.Collections.Generic.Dictionary<PlayerFields, StatsData>();
            this.Fields.Add(PlayerFields.Initiative, new StatsInitiative(this.Owner, 0));
            this.Fields.Add(PlayerFields.Prospecting, new StatsData(this.Owner, PlayerFields.Prospecting, 100, StatsFields.FormulasChanceDependant));
            this.Fields.Add(PlayerFields.AP, new StatsAP(this.Owner, (int)((short)record.actionPoints)));
            this.Fields.Add(PlayerFields.MP, new StatsMP(this.Owner, (int)((short)record.movementPoints)));
            this.Fields.Add(PlayerFields.Strength, new StatsData(this.Owner, PlayerFields.Strength, 0, null));
            this.Fields.Add(PlayerFields.Vitality, new StatsData(this.Owner, PlayerFields.Vitality, (short)record.lifePoints, null));
            this.Fields.Add(PlayerFields.Health, new StatsHealth(this.Owner, 0, 0));
            this.Fields.Add(PlayerFields.Wisdom, new StatsData(this.Owner, PlayerFields.Wisdom, (int)record.wisdom, null));
            this.Fields.Add(PlayerFields.Chance, new StatsData(this.Owner, PlayerFields.Chance, 0, null));
            this.Fields.Add(PlayerFields.Agility, new StatsData(this.Owner, PlayerFields.Agility, 0, null));
            this.Fields.Add(PlayerFields.Intelligence, new StatsData(this.Owner, PlayerFields.Intelligence, 0, null));
            this.Fields.Add(PlayerFields.Range, new StatsData(this.Owner, PlayerFields.Range, 0, null));
            this.Fields.Add(PlayerFields.SummonLimit, new StatsData(this.Owner, PlayerFields.SummonLimit, 1, null));
            this.Fields.Add(PlayerFields.DamageReflection, new StatsData(this.Owner, PlayerFields.DamageReflection, 0, null));
            this.Fields.Add(PlayerFields.CriticalHit, new StatsData(this.Owner, PlayerFields.CriticalHit, 0, null));
            this.Fields.Add(PlayerFields.CriticalMiss, new StatsData(this.Owner, PlayerFields.CriticalMiss, 0, null));
            this.Fields.Add(PlayerFields.HealBonus, new StatsData(this.Owner, PlayerFields.HealBonus, 0, null));
            this.Fields.Add(PlayerFields.DamageBonus, new StatsData(this.Owner, PlayerFields.DamageBonus, 0, null));
            this.Fields.Add(PlayerFields.WeaponDamageBonus, new StatsData(this.Owner, PlayerFields.WeaponDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.DamageBonusPercent, new StatsData(this.Owner, PlayerFields.DamageBonusPercent, 0, null));
            this.Fields.Add(PlayerFields.TrapBonus, new StatsData(this.Owner, PlayerFields.TrapBonus, 0, null));
            this.Fields.Add(PlayerFields.TrapBonusPercent, new StatsData(this.Owner, PlayerFields.TrapBonusPercent, 0, null));
            this.Fields.Add(PlayerFields.PermanentDamagePercent, new StatsData(this.Owner, PlayerFields.PermanentDamagePercent, 0, null));
            this.Fields.Add(PlayerFields.TackleBlock, new StatsData(this.Owner, PlayerFields.TackleBlock, 0, StatsFields.FormulasAgilityDependant));
            this.Fields.Add(PlayerFields.TackleEvade, new StatsData(this.Owner, PlayerFields.TackleEvade, 0, StatsFields.FormulasAgilityDependant));
            this.Fields.Add(PlayerFields.APAttack, new StatsData(this.Owner, PlayerFields.APAttack, 0, null));
            this.Fields.Add(PlayerFields.MPAttack, new StatsData(this.Owner, PlayerFields.MPAttack, 0, null));
            this.Fields.Add(PlayerFields.PushDamageBonus, new StatsData(this.Owner, PlayerFields.PushDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.CriticalDamageBonus, new StatsData(this.Owner, PlayerFields.CriticalDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.NeutralDamageBonus, new StatsData(this.Owner, PlayerFields.NeutralDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.EarthDamageBonus, new StatsData(this.Owner, PlayerFields.EarthDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.WaterDamageBonus, new StatsData(this.Owner, PlayerFields.WaterDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.AirDamageBonus, new StatsData(this.Owner, PlayerFields.AirDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.FireDamageBonus, new StatsData(this.Owner, PlayerFields.FireDamageBonus, 0, null));
            this.Fields.Add(PlayerFields.DodgeAPProbability, new StatsData(this.Owner, PlayerFields.DodgeAPProbability, (int)((short)record.paDodge), StatsFields.FormulasWisdomDependant));
            this.Fields.Add(PlayerFields.DodgeMPProbability, new StatsData(this.Owner, PlayerFields.DodgeMPProbability, (int)((short)record.pmDodge), StatsFields.FormulasWisdomDependant));
            this.Fields.Add(PlayerFields.NeutralResistPercent, new StatsData(this.Owner, PlayerFields.NeutralResistPercent, (int)((short)record.neutralResistance), null));
            this.Fields.Add(PlayerFields.EarthResistPercent, new StatsData(this.Owner, PlayerFields.EarthResistPercent, (int)((short)record.earthResistance), null));
            this.Fields.Add(PlayerFields.WaterResistPercent, new StatsData(this.Owner, PlayerFields.WaterResistPercent, (int)((short)record.waterResistance), null));
            this.Fields.Add(PlayerFields.AirResistPercent, new StatsData(this.Owner, PlayerFields.AirResistPercent, (int)((short)record.airResistance), null));
            this.Fields.Add(PlayerFields.FireResistPercent, new StatsData(this.Owner, PlayerFields.FireResistPercent, (short)record.fireResistance, null));
            this.Fields.Add(PlayerFields.NeutralElementReduction, new StatsData(this.Owner, PlayerFields.NeutralElementReduction, 0, null));
            this.Fields.Add(PlayerFields.EarthElementReduction, new StatsData(this.Owner, PlayerFields.EarthElementReduction, 0, null));
            this.Fields.Add(PlayerFields.WaterElementReduction, new StatsData(this.Owner, PlayerFields.WaterElementReduction, 0, null));
            this.Fields.Add(PlayerFields.AirElementReduction, new StatsData(this.Owner, PlayerFields.AirElementReduction, 0, null));
            this.Fields.Add(PlayerFields.FireElementReduction, new StatsData(this.Owner, PlayerFields.FireElementReduction, 0, null));
            this.Fields.Add(PlayerFields.PushDamageReduction, new StatsData(this.Owner, PlayerFields.PushDamageReduction, 0, null));
            this.Fields.Add(PlayerFields.CriticalDamageReduction, new StatsData(this.Owner, PlayerFields.CriticalDamageReduction, 0, null));
            this.Fields.Add(PlayerFields.PvpNeutralResistPercent, new StatsData(this.Owner, PlayerFields.PvpNeutralResistPercent, 0, null));
            this.Fields.Add(PlayerFields.PvpEarthResistPercent, new StatsData(this.Owner, PlayerFields.PvpEarthResistPercent, 0, null));
            this.Fields.Add(PlayerFields.PvpWaterResistPercent, new StatsData(this.Owner, PlayerFields.PvpWaterResistPercent, 0, null));
            this.Fields.Add(PlayerFields.PvpAirResistPercent, new StatsData(this.Owner, PlayerFields.PvpAirResistPercent, 0, null));
            this.Fields.Add(PlayerFields.PvpFireResistPercent, new StatsData(this.Owner, PlayerFields.PvpFireResistPercent, 0, null));
            this.Fields.Add(PlayerFields.PvpNeutralElementReduction, new StatsData(this.Owner, PlayerFields.PvpNeutralElementReduction, 0, null));
            this.Fields.Add(PlayerFields.PvpEarthElementReduction, new StatsData(this.Owner, PlayerFields.PvpEarthElementReduction, 0, null));
            this.Fields.Add(PlayerFields.PvpWaterElementReduction, new StatsData(this.Owner, PlayerFields.PvpWaterElementReduction, 0, null));
            this.Fields.Add(PlayerFields.PvpAirElementReduction, new StatsData(this.Owner, PlayerFields.PvpAirElementReduction, 0, null));
            this.Fields.Add(PlayerFields.PvpFireElementReduction, new StatsData(this.Owner, PlayerFields.PvpFireElementReduction, 0, null));
            this.Fields.Add(PlayerFields.GlobalDamageReduction, new StatsData(this.Owner, PlayerFields.GlobalDamageReduction, 0, null));
            this.Fields.Add(PlayerFields.DamageMultiplicator, new StatsData(this.Owner, PlayerFields.DamageMultiplicator, 0, null));
            this.Fields.Add(PlayerFields.PhysicalDamage, new StatsData(this.Owner, PlayerFields.PhysicalDamage, 0, null));
            this.Fields.Add(PlayerFields.MagicDamage, new StatsData(this.Owner, PlayerFields.MagicDamage, 0, null));
            this.Fields.Add(PlayerFields.PhysicalDamageReduction, new StatsData(this.Owner, PlayerFields.PhysicalDamageReduction, 0, null));
            this.Fields.Add(PlayerFields.MagicDamageReduction, new StatsData(this.Owner, PlayerFields.MagicDamageReduction, 0, null));
            this.Fields.Add(PlayerFields.WaterDamageArmor, new StatsData(this.Owner, PlayerFields.WaterDamageArmor, 0, null));
            this.Fields.Add(PlayerFields.EarthDamageArmor, new StatsData(this.Owner, PlayerFields.EarthDamageArmor, 0, null));
            this.Fields.Add(PlayerFields.NeutralDamageArmor, new StatsData(this.Owner, PlayerFields.NeutralDamageArmor, 0, null));
            this.Fields.Add(PlayerFields.AirDamageArmor, new StatsData(this.Owner, PlayerFields.AirDamageArmor, 0, null));
            this.Fields.Add(PlayerFields.FireDamageArmor, new StatsData(this.Owner, PlayerFields.FireDamageArmor, 0, null));
            this.Fields.Add(PlayerFields.Erosion, new StatsData(this.Owner, PlayerFields.Erosion, 10, null));
            this.Fields.Add(PlayerFields.Shield, new StatsData(this.Owner, PlayerFields.Shield, 0, null));
            this.Fields.Add(PlayerFields.GlyphBonus, new StatsData(this.Owner, PlayerFields.GlyphBonus, 0, null));
            this.Fields.Add(PlayerFields.GlyphBonusPercent, new StatsData(this.Owner, PlayerFields.GlyphBonusPercent, 0, null));
            this.Fields.Add(PlayerFields.HealMultiplicator, new StatsData(this.Owner, PlayerFields.HealMultiplicator, 0, null));
            this.Fields.Add(PlayerFields.BombBonus, new StatsData(this.Owner, PlayerFields.BombBonus, 0, null));
            this.Fields.Add(PlayerFields.FinalDamage, new StatsData(this.Owner, PlayerFields.FinalDamage, 0, null));
        }
        //public void Initialize(TaxCollectorNpc taxCollector)
        //{
        //    this.Fields = new System.Collections.Generic.Dictionary<PlayerFields, StatsData>();
        //    this.Fields.Add(PlayerFields.Initiative, new StatsInitiative(this.Owner, 0));
        //    this.Fields.Add(PlayerFields.Prospecting, new StatsData(this.Owner, PlayerFields.Prospecting, taxCollector.Guild.TaxCollectorProspecting, StatsFields.FormulasChanceDependant));
        //    this.Fields.Add(PlayerFields.AP, new StatsAP(this.Owner, TaxCollectorNpc.BaseAP));
        //    this.Fields.Add(PlayerFields.MP, new StatsMP(this.Owner, TaxCollectorNpc.BaseMP));
        //    this.Fields.Add(PlayerFields.Strength, new StatsData(this.Owner, PlayerFields.Strength, 0, null));
        //    this.Fields.Add(PlayerFields.Vitality, new StatsData(this.Owner, PlayerFields.Vitality, 0, null));
        //    this.Fields.Add(PlayerFields.Health, new StatsHealth(this.Owner, taxCollector.Guild.TaxCollectorHealth, 0));
        //    this.Fields.Add(PlayerFields.Wisdom, new StatsData(this.Owner, PlayerFields.Wisdom, taxCollector.Guild.TaxCollectorWisdom, null));
        //    this.Fields.Add(PlayerFields.Chance, new StatsData(this.Owner, PlayerFields.Chance, 0, null));
        //    this.Fields.Add(PlayerFields.Agility, new StatsData(this.Owner, PlayerFields.Agility, 0, null));
        //    this.Fields.Add(PlayerFields.Intelligence, new StatsData(this.Owner, PlayerFields.Intelligence, 0, null));
        //    this.Fields.Add(PlayerFields.Range, new StatsData(this.Owner, PlayerFields.Range, 0, null));
        //    this.Fields.Add(PlayerFields.SummonLimit, new StatsData(this.Owner, PlayerFields.SummonLimit, 1, null));
        //    this.Fields.Add(PlayerFields.DamageReflection, new StatsData(this.Owner, PlayerFields.DamageReflection, 0, null));
        //    this.Fields.Add(PlayerFields.CriticalHit, new StatsData(this.Owner, PlayerFields.CriticalHit, 0, null));
        //    this.Fields.Add(PlayerFields.CriticalMiss, new StatsData(this.Owner, PlayerFields.CriticalMiss, 0, null));
        //    this.Fields.Add(PlayerFields.HealBonus, new StatsData(this.Owner, PlayerFields.HealBonus, 0, null));
        //    this.Fields.Add(PlayerFields.DamageBonus, new StatsData(this.Owner, PlayerFields.DamageBonus, taxCollector.Guild.TaxCollectorDamageBonuses, null));
        //    this.Fields.Add(PlayerFields.WeaponDamageBonus, new StatsData(this.Owner, PlayerFields.WeaponDamageBonus, 0, null));
        //    this.Fields.Add(PlayerFields.DamageBonusPercent, new StatsData(this.Owner, PlayerFields.DamageBonusPercent, 0, null));
        //    this.Fields.Add(PlayerFields.TrapBonus, new StatsData(this.Owner, PlayerFields.TrapBonus, 0, null));
        //    this.Fields.Add(PlayerFields.TrapBonusPercent, new StatsData(this.Owner, PlayerFields.TrapBonusPercent, 0, null));
        //    this.Fields.Add(PlayerFields.PermanentDamagePercent, new StatsData(this.Owner, PlayerFields.PermanentDamagePercent, 0, null));
        //    this.Fields.Add(PlayerFields.TackleBlock, new StatsData(this.Owner, PlayerFields.TackleBlock, 50, StatsFields.FormulasAgilityDependant));
        //    this.Fields.Add(PlayerFields.TackleEvade, new StatsData(this.Owner, PlayerFields.TackleEvade, 50, StatsFields.FormulasAgilityDependant));
        //    this.Fields.Add(PlayerFields.APAttack, new StatsData(this.Owner, PlayerFields.APAttack, 50, null));
        //    this.Fields.Add(PlayerFields.MPAttack, new StatsData(this.Owner, PlayerFields.MPAttack, 50, null));
        //    this.Fields.Add(PlayerFields.PushDamageBonus, new StatsData(this.Owner, PlayerFields.PushDamageBonus, 0, null));
        //    this.Fields.Add(PlayerFields.CriticalDamageBonus, new StatsData(this.Owner, PlayerFields.CriticalDamageBonus, 0, null));
        //    this.Fields.Add(PlayerFields.NeutralDamageBonus, new StatsData(this.Owner, PlayerFields.NeutralDamageBonus, 0, null));
        //    this.Fields.Add(PlayerFields.EarthDamageBonus, new StatsData(this.Owner, PlayerFields.EarthDamageBonus, 0, null));
        //    this.Fields.Add(PlayerFields.WaterDamageBonus, new StatsData(this.Owner, PlayerFields.WaterDamageBonus, 0, null));
        //    this.Fields.Add(PlayerFields.AirDamageBonus, new StatsData(this.Owner, PlayerFields.AirDamageBonus, 0, null));
        //    this.Fields.Add(PlayerFields.FireDamageBonus, new StatsData(this.Owner, PlayerFields.FireDamageBonus, 0, null));
        //    this.Fields.Add(PlayerFields.DodgeAPProbability, new StatsData(this.Owner, PlayerFields.DodgeAPProbability, TaxCollectorNpc.BaseResistance, StatsFields.FormulasWisdomDependant));
        //    this.Fields.Add(PlayerFields.DodgeMPProbability, new StatsData(this.Owner, PlayerFields.DodgeMPProbability, TaxCollectorNpc.BaseResistance, StatsFields.FormulasWisdomDependant));
        //    this.Fields.Add(PlayerFields.NeutralResistPercent, new StatsData(this.Owner, PlayerFields.NeutralResistPercent, TaxCollectorNpc.BaseResistance, null));
        //    this.Fields.Add(PlayerFields.EarthResistPercent, new StatsData(this.Owner, PlayerFields.EarthResistPercent, TaxCollectorNpc.BaseResistance, null));
        //    this.Fields.Add(PlayerFields.WaterResistPercent, new StatsData(this.Owner, PlayerFields.WaterResistPercent, TaxCollectorNpc.BaseResistance, null));
        //    this.Fields.Add(PlayerFields.AirResistPercent, new StatsData(this.Owner, PlayerFields.AirResistPercent, TaxCollectorNpc.BaseResistance, null));
        //    this.Fields.Add(PlayerFields.FireResistPercent, new StatsData(this.Owner, PlayerFields.FireResistPercent, TaxCollectorNpc.BaseResistance, null));
        //    this.Fields.Add(PlayerFields.NeutralElementReduction, new StatsData(this.Owner, PlayerFields.NeutralElementReduction, 0, null));
        //    this.Fields.Add(PlayerFields.EarthElementReduction, new StatsData(this.Owner, PlayerFields.EarthElementReduction, 0, null));
        //    this.Fields.Add(PlayerFields.WaterElementReduction, new StatsData(this.Owner, PlayerFields.WaterElementReduction, 0, null));
        //    this.Fields.Add(PlayerFields.AirElementReduction, new StatsData(this.Owner, PlayerFields.AirElementReduction, 0, null));
        //    this.Fields.Add(PlayerFields.FireElementReduction, new StatsData(this.Owner, PlayerFields.FireElementReduction, 0, null));
        //    this.Fields.Add(PlayerFields.PushDamageReduction, new StatsData(this.Owner, PlayerFields.PushDamageReduction, 0, null));
        //    this.Fields.Add(PlayerFields.CriticalDamageReduction, new StatsData(this.Owner, PlayerFields.CriticalDamageReduction, 0, null));
        //    this.Fields.Add(PlayerFields.PvpNeutralResistPercent, new StatsData(this.Owner, PlayerFields.PvpNeutralResistPercent, 0, null));
        //    this.Fields.Add(PlayerFields.PvpEarthResistPercent, new StatsData(this.Owner, PlayerFields.PvpEarthResistPercent, 0, null));
        //    this.Fields.Add(PlayerFields.PvpWaterResistPercent, new StatsData(this.Owner, PlayerFields.PvpWaterResistPercent, 0, null));
        //    this.Fields.Add(PlayerFields.PvpAirResistPercent, new StatsData(this.Owner, PlayerFields.PvpAirResistPercent, 0, null));
        //    this.Fields.Add(PlayerFields.PvpFireResistPercent, new StatsData(this.Owner, PlayerFields.PvpFireResistPercent, 0, null));
        //    this.Fields.Add(PlayerFields.PvpNeutralElementReduction, new StatsData(this.Owner, PlayerFields.PvpNeutralElementReduction, 0, null));
        //    this.Fields.Add(PlayerFields.PvpEarthElementReduction, new StatsData(this.Owner, PlayerFields.PvpEarthElementReduction, 0, null));
        //    this.Fields.Add(PlayerFields.PvpWaterElementReduction, new StatsData(this.Owner, PlayerFields.PvpWaterElementReduction, 0, null));
        //    this.Fields.Add(PlayerFields.PvpAirElementReduction, new StatsData(this.Owner, PlayerFields.PvpAirElementReduction, 0, null));
        //    this.Fields.Add(PlayerFields.PvpFireElementReduction, new StatsData(this.Owner, PlayerFields.PvpFireElementReduction, 0, null));
        //    this.Fields.Add(PlayerFields.GlobalDamageReduction, new StatsData(this.Owner, PlayerFields.GlobalDamageReduction, 0, null));
        //    this.Fields.Add(PlayerFields.DamageMultiplicator, new StatsData(this.Owner, PlayerFields.DamageMultiplicator, 0, null));
        //    this.Fields.Add(PlayerFields.PhysicalDamage, new StatsData(this.Owner, PlayerFields.PhysicalDamage, 0, null));
        //    this.Fields.Add(PlayerFields.MagicDamage, new StatsData(this.Owner, PlayerFields.MagicDamage, 0, null));
        //    this.Fields.Add(PlayerFields.PhysicalDamageReduction, new StatsData(this.Owner, PlayerFields.PhysicalDamageReduction, 0, null));
        //    this.Fields.Add(PlayerFields.MagicDamageReduction, new StatsData(this.Owner, PlayerFields.MagicDamageReduction, 0, null));
        //    this.Fields.Add(PlayerFields.WaterDamageArmor, new StatsData(this.Owner, PlayerFields.WaterDamageArmor, 0, null));
        //    this.Fields.Add(PlayerFields.EarthDamageArmor, new StatsData(this.Owner, PlayerFields.EarthDamageArmor, 0, null));
        //    this.Fields.Add(PlayerFields.NeutralDamageArmor, new StatsData(this.Owner, PlayerFields.NeutralDamageArmor, 0, null));
        //    this.Fields.Add(PlayerFields.AirDamageArmor, new StatsData(this.Owner, PlayerFields.AirDamageArmor, 0, null));
        //    this.Fields.Add(PlayerFields.FireDamageArmor, new StatsData(this.Owner, PlayerFields.FireDamageArmor, 0, null));
        //    this.Fields.Add(PlayerFields.Erosion, new StatsData(this.Owner, PlayerFields.Erosion, 10, null));
        //    this.Fields.Add(PlayerFields.Shield, new StatsData(this.Owner, PlayerFields.Shield, 0, null));
        //}

        #endregion

        #region SpellBoosts
        public StatsSpellBoost SpellBoosts
        {
            get;
            set;
        }
        #endregion

        public void Revive()
        {
            foreach (var item in Fields)
            {
                item.Value.Base = 0;
                item.Value.Additionnal = 0;
                item.Value.Alignement = 0;
                item.Value.Context = 0;
                item.Value.Equiped = 0;
                item.Value.Given = 0;
            }
            Health.DamageTaken = 0;
            Health.Base = 55;
            AP.Base = 6;
            MP.Base = 3;
            Prospecting.Base = 100;
        }

        public void KillItems()
        {
            foreach (var item in Fields)
            {
                item.Value.Equiped = 0;
            }
        }

        public StatsFields CloneAndChangeOwner(IStatsOwner owner)
        {
            StatsFields statsFields = new StatsFields(owner);
            statsFields.Fields = this.Fields.ToDictionary((System.Collections.Generic.KeyValuePair<PlayerFields, StatsData> x) => x.Key, (System.Collections.Generic.KeyValuePair<PlayerFields, StatsData> x) => x.Value.CloneAndChangeOwner(owner));
            statsFields.SpellBoosts = new StatsSpellBoost();
            return statsFields;
        }

    }
}
