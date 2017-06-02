


















// Generated on 01/12/2017 03:52:53
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class AllianceChangeGuildRightsMessage : NetworkMessage
{

public const uint Id = 6426;
public uint MessageId
{
    get { return Id; }
}

public uint guildId;
        public sbyte rights;
        

public AllianceChangeGuildRightsMessage()
{
}

public AllianceChangeGuildRightsMessage(uint guildId, sbyte rights)
        {
            this.guildId = guildId;
            this.rights = rights;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)guildId);
            writer.WriteSByte(rights);
            

}

public void Deserialize(IDataReader reader)
{

guildId = reader.ReadVarUhInt();
            if (guildId < 0)
                throw new System.Exception("Forbidden value on guildId = " + guildId + ", it doesn't respect the following condition : guildId < 0");
            rights = reader.ReadSByte();
            if (rights < 0)
                throw new System.Exception("Forbidden value on rights = " + rights + ", it doesn't respect the following condition : rights < 0");
            

}


}


}