using Rebirth.Common.Extensions;
using Rebirth.World.Datas.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rebirth.World.Managers
{
    public class ExperienceManager : DataManager<ExperienceManager>
    {
        private readonly System.Collections.Generic.Dictionary<byte, ExperienceTableEntry> m_records = new System.Collections.Generic.Dictionary<byte, ExperienceTableEntry>();
        private System.Collections.Generic.KeyValuePair<byte, ExperienceTableEntry> m_highestCharacterLevel;
        private System.Collections.Generic.KeyValuePair<byte, ExperienceTableEntry> m_highestGrade;
        private System.Collections.Generic.KeyValuePair<byte, ExperienceTableEntry> m_highestGuildLevel;
        private System.Collections.Generic.KeyValuePair<byte, ExperienceTableEntry> m_highestJobLevel;
        private System.Collections.Generic.KeyValuePair<byte, ExperienceTableEntry> m_highestMountLevel;
        public byte HighestCharacterLevel
        {
            get
            {
                return this.m_highestCharacterLevel.Key;
            }
        }
        public byte HighestGuildLevel
        {
            get
            {
                return this.m_highestGuildLevel.Key;
            }
        }
        public byte HighestGrade
        {
            get
            {
                return this.m_highestGrade.Key;
            }
        }
        public long GetCharacterLevelExperience(byte level)
        {
            if (!this.m_records.ContainsKey(level))
            {
                throw new System.Exception("Level " + level + " not found");
            }
            long? characterExp = this.m_records[level].CharacterExp;
            if (!characterExp.HasValue)
            {
                throw new System.Exception("Character level " + level + " is not defined");
            }
            return characterExp.Value;
        }
        public long GetCharacterNextLevelExperience(byte level)
        {
            long result;
            if (this.m_records.ContainsKey(Convert.ToByte(level + 1)))
            {
                long? characterExp = this.m_records[Convert.ToByte(level + 1)].CharacterExp;
                if (!characterExp.HasValue)
                {
                    throw new System.Exception("Character level " + level + " is not defined");
                }
                result = characterExp.Value;
            }
            else
            {
                result = ((long)9.007199254740992E15) - 1;
            }
            return result;
        }
        public byte GetCharacterLevel(long experience)
        {
            byte result;
            try
            {
                if (experience >= this.m_highestCharacterLevel.Value.CharacterExp)
                {
                    result = this.m_highestCharacterLevel.Key;
                }
                else
                {
                    result = Convert.ToByte(this.m_records.First((System.Collections.Generic.KeyValuePair<byte, ExperienceTableEntry> entry) => entry.Value.CharacterExp > experience).Key - 1);
                }
            }
            catch (System.InvalidOperationException innerException)
            {
                throw new System.Exception(string.Format("Experience {0} isn't bind to a character level", experience), innerException);
            }
            return result;
        }
        public ushort GetAlignementGradeHonor(byte grade)
        {
            if (!this.m_records.ContainsKey(grade))
            {
                throw new System.Exception("Grade " + grade + " not found");
            }
            ushort? alignmentHonor = this.m_records[grade].AlignmentHonor;
            if (!alignmentHonor.HasValue)
            {
                throw new System.Exception("Grade " + grade + " is not defined");
            }
            return alignmentHonor.Value;
        }
        public ushort GetAlignementNextGradeHonor(byte grade)
        {
            ushort result;
            if (!this.m_records.ContainsKey(Convert.ToByte(grade + 1)))
            {
                result = 17500;
            }
            else
            {
                ushort? alignmentHonor = this.m_records[Convert.ToByte(grade + 1)].AlignmentHonor;
                result = Convert.ToUInt16((!alignmentHonor.HasValue) ? 17500 : alignmentHonor.Value);
            }
            return result;
        }
        public byte GetAlignementGrade(ushort honor)
        {

            byte result;
            try
            {
                if (honor >= this.m_highestGrade.Value.AlignmentHonor)
                {
                    result = this.m_highestGrade.Key;
                }
                else
                {
                    result = Convert.ToByte(this.m_records.First((System.Collections.Generic.KeyValuePair<byte, ExperienceTableEntry> entry) => entry.Value.AlignmentHonor > honor).Key - 1);
                }
            }
            catch (System.InvalidOperationException innerException)
            {
                throw new System.Exception(string.Format("Honor {0} isn't bind to a grade", honor), innerException);
            }
            return result;
        }
        public long GetGuildLevelExperience(byte level)
        {
            if (!this.m_records.ContainsKey(level))
            {
                throw new System.Exception("Level " + level + " not found");
            }
            long? guildExp = this.m_records[level].GuildExp;
            if (!guildExp.HasValue)
            {
                throw new System.Exception("Guild level " + level + " is not defined");
            }
            return guildExp.Value;
        }

        public long GetGuildNextLevelExperience(byte level)
        {
            long result;
            if (this.m_records.ContainsKey(Convert.ToByte(level + 1)))
            {
                long? guildExp = this.m_records[Convert.ToByte(level + 1)].GuildExp;
                if (!guildExp.HasValue)
                {
                    throw new System.Exception("Guild level " + level + " is not defined");
                }
                result = guildExp.Value;
            }
            else
            {
                result = 9223372036854775807L;
            }
            return result;
        }

        public byte GetGuildLevel(long experience)
        {

            byte result;
            try
            {
                if (experience >= this.m_highestGuildLevel.Value.GuildExp)
                {
                    result = this.m_highestGuildLevel.Key;
                }
                else
                {

                    result = Convert.ToByte(this.m_records.First((System.Collections.Generic.KeyValuePair<byte, ExperienceTableEntry> entry) => entry.Value.GuildExp > experience).Key - 1);
                }
            }
            catch (System.InvalidOperationException innerException)
            {

                throw new System.Exception(string.Format("Experience {0} isn't bind to a guild level", experience), innerException);
            }
            return result;
        }
        public long GetMountLevelExperience(byte level)
        {

            long num;
            if (this.m_records.ContainsKey(Convert.ToByte(level)))
            {
                long? mountExp = this.m_records[Convert.ToByte(level)].MountExp;
                if (!mountExp.HasValue)
                    throw new Exception("Mount level " + (object)level + " is not defined");
                num = mountExp.Value;
            }
            else
                num = long.MaxValue;
            return num;
        }

        public long GetMountNextLevelExperience(byte level)
        {
            if (level == 100)
                return (long)this.m_records[Convert.ToByte(100)].MountExp;

            long num;
            if (this.m_records.ContainsKey(Convert.ToByte((int)level + 1)))
            {
                long? mountExp = this.m_records[Convert.ToByte((int)level + 1)].MountExp;
                if (!mountExp.HasValue)
                    throw new Exception("Mount level " + (object)level + " is not defined");
                num = mountExp.Value;
            }
            else
                num = long.MaxValue;
            return num;
        }

        public byte GetMountLevel(long experience)
        {
            byte num1;
            try
            {
                long num2 = experience;
                long? mountExp1 = this.m_highestMountLevel.Value.MountExp;
                num1 = (num2 < mountExp1.GetValueOrDefault() ? 0 : (mountExp1.HasValue ? 1 : 0)) == 0 ? Convert.ToByte((int)Enumerable.First<KeyValuePair<byte, ExperienceTableEntry>>((IEnumerable<KeyValuePair<byte, ExperienceTableEntry>>)this.m_records, (Func<KeyValuePair<byte, ExperienceTableEntry>, bool>)(entry =>
                {
                    long? mountExp = entry.Value.MountExp;
                    return mountExp.GetValueOrDefault() > num2 && mountExp.HasValue;
                })).Key - 1) : this.m_highestMountLevel.Key;
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception(string.Format("Experience {0} isn't bind to a guild level", (object)experience), (Exception)ex);
            }
            return num1;
        }

        public double GetJobLevelExperience(byte level)
        {
            double num;
            if (this.m_records.ContainsKey(Convert.ToByte(level)))
            {
                long? jobExp = this.m_records[Convert.ToByte(level)].JobExp;
                if (!jobExp.HasValue)
                    throw new Exception("Job level " + (object)level + " is not defined");
                num = (double)jobExp.Value;
            }
            else
                num = long.MaxValue;
            return num;
        }

        public double GetJobNextLevelExperience(byte level)
        {
            long num;
            if (this.m_records.ContainsKey(Convert.ToByte((int)level + 1)))
            {
                long? jobExp = this.m_records[Convert.ToByte((int)level + 1)].JobExp;
                if (!jobExp.HasValue)
                    throw new Exception("Job level " + (object)level + " is not defined");
                num = jobExp.Value;
            }
            else
                num = long.MaxValue;
            return num;
        }

        public byte GetJobLevel(long experience)
        {
            byte num1;
            try
            {
                long num2 = experience;
                long? jobExp1 = this.m_highestJobLevel.Value.JobExp;
                num1 = (num2 < jobExp1.GetValueOrDefault() ? 0 : (jobExp1.HasValue ? 1 : 0)) == 0 ? Convert.ToByte((int)Enumerable.First<KeyValuePair<byte, ExperienceTableEntry>>((IEnumerable<KeyValuePair<byte, ExperienceTableEntry>>)this.m_records, (Func<KeyValuePair<byte, ExperienceTableEntry>, bool>)(entry =>
                {
                    long? jobExp = entry.Value.JobExp;
                    return jobExp.GetValueOrDefault() > num2 && jobExp.HasValue;
                })).Key - 1) : this.m_highestJobLevel.Key;
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception(string.Format("Experience {0} isn't bind to a job level", (object)experience), (Exception)ex);
            }
            return num1;
        }

        public void Initialize()
        {
            foreach (ExperienceTableEntry current in Starter.Database.Query<ExperienceTableEntry>("SELECT * FROM experiences"))
            {
                if (current.Level > 200)
                {
                    throw new System.Exception("Level cannot exceed 200 (protocol constraint)");
                }
                this.m_records.Add((byte)current.Level, current);
            }
            this.m_highestCharacterLevel = (
                from entry in this.m_records
                orderby entry.Value.CharacterExp descending
                select entry).FirstOrDefault<System.Collections.Generic.KeyValuePair<byte, ExperienceTableEntry>>();
            this.m_highestGrade = (
                from entry in this.m_records
                orderby entry.Value.AlignmentHonor descending
                select entry).FirstOrDefault<System.Collections.Generic.KeyValuePair<byte, ExperienceTableEntry>>();
            this.m_highestGuildLevel = (
                from entry in this.m_records
                orderby entry.Value.GuildExp descending
                select entry).FirstOrDefault<System.Collections.Generic.KeyValuePair<byte, ExperienceTableEntry>>();
            this.m_highestJobLevel = (
                from entry in this.m_records
                orderby entry.Value.JobExp descending
                select entry).FirstOrDefault<System.Collections.Generic.KeyValuePair<byte, ExperienceTableEntry>>();

            this.m_highestMountLevel = (
                from entry in this.m_records
                orderby entry.Value.MountExp descending
                select entry).FirstOrDefault<System.Collections.Generic.KeyValuePair<byte, ExperienceTableEntry>>();
        }
    }
}
