


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class JobAllowMultiCraftRequestMessage : NetworkMessage
{

public const uint Id = 5748;
public uint MessageId
{
    get { return Id; }
}

public bool enabled;
        

public JobAllowMultiCraftRequestMessage()
{
}

public JobAllowMultiCraftRequestMessage(bool enabled)
        {
            this.enabled = enabled;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(enabled);
            

}

public void Deserialize(IDataReader reader)
{

enabled = reader.ReadBoolean();
            

}


}


}