


















// Generated on 01/12/2017 03:53:04
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectErrorMessage : NetworkMessage
{

public const uint Id = 3004;
public uint MessageId
{
    get { return Id; }
}

public sbyte reason;
        

public ObjectErrorMessage()
{
}

public ObjectErrorMessage(sbyte reason)
        {
            this.reason = reason;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(reason);
            

}

public void Deserialize(IDataReader reader)
{

reason = reader.ReadSByte();
            

}


}


}