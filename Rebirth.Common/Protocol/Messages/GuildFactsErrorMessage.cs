


















// Generated on 01/12/2017 03:53:00
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildFactsErrorMessage : NetworkMessage
{

public const uint Id = 6424;
public uint MessageId
{
    get { return Id; }
}

public uint guildId;
        

public GuildFactsErrorMessage()
{
}

public GuildFactsErrorMessage(uint guildId)
        {
            this.guildId = guildId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)guildId);
            

}

public void Deserialize(IDataReader reader)
{

guildId = reader.ReadVarUhInt();
            if (guildId < 0)
                throw new System.Exception("Forbidden value on guildId = " + guildId + ", it doesn't respect the following condition : guildId < 0");
            

}


}


}