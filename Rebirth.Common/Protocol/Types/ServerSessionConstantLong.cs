


















// Generated on 01/12/2017 03:53:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ServerSessionConstantLong : ServerSessionConstant
{

public const short Id = 429;
public override short TypeId
{
    get { return Id; }
}

public double value;
        

public ServerSessionConstantLong()
{
}

public ServerSessionConstantLong(uint id, double value)
         : base(id)
        {
            this.value = value;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(value);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadDouble();
            if (value < -9.007199254740992E15 || value > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on value = " + value + ", it doesn't respect the following condition : value < -9.007199254740992E15 || value > 9.007199254740992E15");
            

}


}


}