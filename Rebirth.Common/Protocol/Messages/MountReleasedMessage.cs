


















// Generated on 01/12/2017 03:52:56
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class MountReleasedMessage : NetworkMessage
{

public const uint Id = 6308;
public uint MessageId
{
    get { return Id; }
}

public int mountId;
        

public MountReleasedMessage()
{
}

public MountReleasedMessage(int mountId)
        {
            this.mountId = mountId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)mountId);
            

}

public void Deserialize(IDataReader reader)
{

mountId = reader.ReadVarInt();
            

}


}


}