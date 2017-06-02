


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildMotdSetRequestMessage : SocialNoticeSetRequestMessage
{

public const uint Id = 6588;
public uint MessageId
{
    get { return Id; }
}

public string content;
        

public GuildMotdSetRequestMessage()
{
}

public GuildMotdSetRequestMessage(string content)
        {
            this.content = content;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(content);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            content = reader.ReadUTF();
            

}


}


}