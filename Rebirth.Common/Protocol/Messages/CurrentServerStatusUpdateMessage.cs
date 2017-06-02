


















// Generated on 01/12/2017 03:52:54
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class CurrentServerStatusUpdateMessage : NetworkMessage
{

public const uint Id = 6525;
public uint MessageId
{
    get { return Id; }
}

public sbyte status;
        

public CurrentServerStatusUpdateMessage()
{
}

public CurrentServerStatusUpdateMessage(sbyte status)
        {
            this.status = status;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(status);
            

}

public void Deserialize(IDataReader reader)
{

status = reader.ReadSByte();
            if (status < 0)
                throw new System.Exception("Forbidden value on status = " + status + ", it doesn't respect the following condition : status < 0");
            

}


}


}