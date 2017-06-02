


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildModificationEmblemValidMessage : NetworkMessage
{

public const uint Id = 6328;
public uint MessageId
{
    get { return Id; }
}

public Types.GuildEmblem guildEmblem;
        

public GuildModificationEmblemValidMessage()
{
}

public GuildModificationEmblemValidMessage(Types.GuildEmblem guildEmblem)
        {
            this.guildEmblem = guildEmblem;
        }
        

public void Serialize(IDataWriter writer)
{

guildEmblem.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

guildEmblem = new Types.GuildEmblem();
            guildEmblem.Deserialize(reader);
            

}


}


}