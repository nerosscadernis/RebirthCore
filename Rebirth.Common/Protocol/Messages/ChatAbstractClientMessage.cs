


















// Generated on 01/12/2017 03:52:54
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ChatAbstractClientMessage : NetworkMessage
{

public const uint Id = 850;
public uint MessageId
{
    get { return Id; }
}

public string content;
        

public ChatAbstractClientMessage()
{
}

public ChatAbstractClientMessage(string content)
        {
            this.content = content;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(content);
            

}

public void Deserialize(IDataReader reader)
{

content = reader.ReadUTF();
            

}


}


}