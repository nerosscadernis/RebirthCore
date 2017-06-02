


















// Generated on 01/12/2017 03:52:55
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameContextRemoveElementWithEventMessage : GameContextRemoveElementMessage
{

public const uint Id = 6412;
public uint MessageId
{
    get { return Id; }
}

public sbyte elementEventId;
        

public GameContextRemoveElementWithEventMessage()
{
}

public GameContextRemoveElementWithEventMessage(double id, sbyte elementEventId)
         : base(id)
        {
            this.elementEventId = elementEventId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(elementEventId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            elementEventId = reader.ReadSByte();
            if (elementEventId < 0)
                throw new System.Exception("Forbidden value on elementEventId = " + elementEventId + ", it doesn't respect the following condition : elementEventId < 0");
            

}


}


}