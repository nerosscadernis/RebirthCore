


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildModificationNameValidMessage : NetworkMessage
{

public const uint Id = 6327;
public uint MessageId
{
    get { return Id; }
}

public string guildName;
        

public GuildModificationNameValidMessage()
{
}

public GuildModificationNameValidMessage(string guildName)
        {
            this.guildName = guildName;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(guildName);
            

}

public void Deserialize(IDataReader reader)
{

guildName = reader.ReadUTF();
            

}


}


}