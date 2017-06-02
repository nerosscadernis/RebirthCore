


















// Generated on 01/12/2017 03:53:00
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildHouseTeleportRequestMessage : NetworkMessage
{

public const uint Id = 5712;
public uint MessageId
{
    get { return Id; }
}

public uint houseId;
        

public GuildHouseTeleportRequestMessage()
{
}

public GuildHouseTeleportRequestMessage(uint houseId)
        {
            this.houseId = houseId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)houseId);
            

}

public void Deserialize(IDataReader reader)
{

houseId = reader.ReadVarUhInt();
            if (houseId < 0)
                throw new System.Exception("Forbidden value on houseId = " + houseId + ", it doesn't respect the following condition : houseId < 0");
            

}


}


}