


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildModificationValidMessage : NetworkMessage
{

public const uint Id = 6323;
public uint MessageId
{
    get { return Id; }
}

public string guildName;
        public Types.GuildEmblem guildEmblem;
        

public GuildModificationValidMessage()
{
}

public GuildModificationValidMessage(string guildName, Types.GuildEmblem guildEmblem)
        {
            this.guildName = guildName;
            this.guildEmblem = guildEmblem;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(guildName);
            guildEmblem.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

guildName = reader.ReadUTF();
            guildEmblem = new Types.GuildEmblem();
            guildEmblem.Deserialize(reader);
            

}


}


}