using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Game.Characters.Stats
{
    public class StatsSpellBoost
    {
        private List<SpellBoostTemplate> m_spellsboost = new List<SpellBoostTemplate>();

        public IStatsOwner Owner { get; set; }

        public bool HasBoost(int spellId, CharacterSpellModificationTypeEnum type)
        {
            return m_spellsboost.Any(x => x.Type == type && x.SpellId == spellId);
        }

        public int GetSpellBoost(int spellId, CharacterSpellModificationTypeEnum type)
        {
            var boost = m_spellsboost.FirstOrDefault(x => x.SpellId == spellId && x.Type == type);
            return (boost != null ? boost.Stat.Total : 0);
        }

        public void UpdateBoost(int spellId, CharacterSpellModificationTypeEnum type, int value)
        {
            var stat = m_spellsboost.FirstOrDefault(x => x.SpellId == spellId && x.Type == type);
            if(stat != null)
            {
                stat.Stat.Context += value;
            }
            else
            {
                m_spellsboost.Add(new SpellBoostTemplate()
                {
                    SpellId = (uint)spellId,
                    Stat = new StatsData(Owner, PlayerFields.SpellBoost, value, null),
                    Type = type
                });
            }
        }

        public void RemoveBoost(int spellId, CharacterSpellModificationTypeEnum type, int value)
        {
            var stat = m_spellsboost.FirstOrDefault(x => x.SpellId == spellId && x.Type == type);
            if (stat != null)
            {
                stat.Stat.Context -= value;
                if (stat.Stat.Total == 0)
                    m_spellsboost.Remove(stat);
            }
        }

        public CharacterSpellModification[] GetCharacterSpellModifications()
        {
            return (from x in m_spellsboost
                    select x.GetCharacterSpellModification()).ToArray();
        }
    }

    public class SpellBoostTemplate
    {
        public CharacterSpellModificationTypeEnum Type { get; set; }
        public uint SpellId { get; set; }
        public StatsData Stat { get; set; }

        public CharacterSpellModification GetCharacterSpellModification()
        {
            return new CharacterSpellModification((sbyte)Type, SpellId, Stat);
        }
    }
}