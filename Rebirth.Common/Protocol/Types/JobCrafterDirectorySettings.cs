


















// Generated on 01/12/2017 03:53:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class JobCrafterDirectorySettings : NetworkType
{

public const short Id = 97;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte jobId;
        public byte minLevel;
        public bool free;
        

public JobCrafterDirectorySettings()
{
}

public JobCrafterDirectorySettings(sbyte jobId, byte minLevel, bool free)
        {
            this.jobId = jobId;
            this.minLevel = minLevel;
            this.free = free;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSByte(jobId);
            writer.WriteByte(minLevel);
            writer.WriteBoolean(free);
            

}

public virtual void Deserialize(IDataReader reader)
{

jobId = reader.ReadSByte();
            if (jobId < 0)
                throw new System.Exception("Forbidden value on jobId = " + jobId + ", it doesn't respect the following condition : jobId < 0");
            minLevel = reader.ReadByte();
            if (minLevel < 0 || minLevel > 255)
                throw new System.Exception("Forbidden value on minLevel = " + minLevel + ", it doesn't respect the following condition : minLevel < 0 || minLevel > 255");
            free = reader.ReadBoolean();
            

}


}


}