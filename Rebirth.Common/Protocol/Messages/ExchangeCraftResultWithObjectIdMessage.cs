


















// Generated on 01/12/2017 03:53:02
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeCraftResultWithObjectIdMessage : ExchangeCraftResultMessage
{

public const uint Id = 6000;
public uint MessageId
{
    get { return Id; }
}

public uint objectGenericId;
        

public ExchangeCraftResultWithObjectIdMessage()
{
}

public ExchangeCraftResultWithObjectIdMessage(sbyte craftResult, uint objectGenericId)
         : base(craftResult)
        {
            this.objectGenericId = objectGenericId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)objectGenericId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            objectGenericId = reader.ReadVarUhShort();
            if (objectGenericId < 0)
                throw new System.Exception("Forbidden value on objectGenericId = " + objectGenericId + ", it doesn't respect the following condition : objectGenericId < 0");
            

}


}


}