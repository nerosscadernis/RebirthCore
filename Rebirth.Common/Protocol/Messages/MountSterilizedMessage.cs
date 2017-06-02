


















// Generated on 01/12/2017 03:52:56
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class MountSterilizedMessage : NetworkMessage
{

public const uint Id = 5977;
public uint MessageId
{
    get { return Id; }
}

public int mountId;
        

public MountSterilizedMessage()
{
}

public MountSterilizedMessage(int mountId)
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