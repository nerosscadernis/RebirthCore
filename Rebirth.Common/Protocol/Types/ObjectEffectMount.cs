


















// Generated on 01/12/2017 03:53:09
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ObjectEffectMount : ObjectEffect
{

public const short Id = 179;
public override short TypeId
{
    get { return Id; }
}

public int mountId;
        public double date;
        public uint modelId;
        

public ObjectEffectMount()
{
}

public ObjectEffectMount(uint actionId, int mountId, double date, uint modelId)
         : base(actionId)
        {
            this.mountId = mountId;
            this.date = date;
            this.modelId = modelId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(mountId);
            writer.WriteDouble(date);
            writer.WriteVarShort((int)modelId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            mountId = reader.ReadInt();
            if (mountId < 0)
                throw new System.Exception("Forbidden value on mountId = " + mountId + ", it doesn't respect the following condition : mountId < 0");
            date = reader.ReadDouble();
            if (date < -9.007199254740992E15 || date > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on date = " + date + ", it doesn't respect the following condition : date < -9.007199254740992E15 || date > 9.007199254740992E15");
            modelId = reader.ReadVarUhShort();
            if (modelId < 0)
                throw new System.Exception("Forbidden value on modelId = " + modelId + ", it doesn't respect the following condition : modelId < 0");
            

}


}


}