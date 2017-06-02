using PetaPoco.NetCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Characters
{
    [TableName("experiences")]
    public class ExperienceTableEntry
    {
        public short Level
        {
            get;
            set;
        }
        public long? CharacterExp
        {
            get;
            set;
        }
        public long? GuildExp
        {
            get;
            set;
        }
        public long? MountExp
        {
            get;
            set;
        }
        public ushort? AlignmentHonor
        {
            get;
            set;
        }
        public long? JobExp
        {
            get;
            set;
        }
    }
}
