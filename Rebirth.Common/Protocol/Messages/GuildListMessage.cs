


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildListMessage : NetworkMessage
{

public const uint Id = 6413;
public uint MessageId
{
    get { return Id; }
}

public Types.GuildInformations[] guilds;
        

public GuildListMessage()
{
}

public GuildListMessage(Types.GuildInformations[] guilds)
        {
            this.guilds = guilds;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)guilds.Length);
            foreach (var entry in guilds)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            guilds = new Types.GuildInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 guilds[i] = new Types.GuildInformations();
                 guilds[i].Deserialize(reader);
            }
            

}


}


}