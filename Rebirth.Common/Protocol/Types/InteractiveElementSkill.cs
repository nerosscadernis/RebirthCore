


















// Generated on 01/12/2017 03:53:09
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class InteractiveElementSkill : NetworkType
{

public const short Id = 219;
public virtual short TypeId
{
    get { return Id; }
}

public uint skillId;
        public int skillInstanceUid;
        

public InteractiveElementSkill()
{
}

public InteractiveElementSkill(uint skillId, int skillInstanceUid)
        {
            this.skillId = skillId;
            this.skillInstanceUid = skillInstanceUid;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)skillId);
            writer.WriteInt(skillInstanceUid);
            

}

public virtual void Deserialize(IDataReader reader)
{

skillId = reader.ReadVarUhInt();
            if (skillId < 0)
                throw new System.Exception("Forbidden value on skillId = " + skillId + ", it doesn't respect the following condition : skillId < 0");
            skillInstanceUid = reader.ReadInt();
            if (skillInstanceUid < 0)
                throw new System.Exception("Forbidden value on skillInstanceUid = " + skillInstanceUid + ", it doesn't respect the following condition : skillInstanceUid < 0");
            

}


}


}