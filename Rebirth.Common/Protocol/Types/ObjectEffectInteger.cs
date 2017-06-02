


















// Generated on 01/12/2017 03:53:09
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ObjectEffectInteger : ObjectEffect
{

public const short Id = 70;
public override short TypeId
{
    get { return Id; }
}

public uint value;
        

public ObjectEffectInteger()
{
}

public ObjectEffectInteger(uint actionId, uint value)
         : base(actionId)
        {
            this.value = value;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)value);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadVarUhShort();
            if (value < 0)
                throw new System.Exception("Forbidden value on value = " + value + ", it doesn't respect the following condition : value < 0");
            

}


}


}