


















// Generated on 01/12/2017 03:52:54
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ChatClientPrivateMessage : ChatAbstractClientMessage
{

public const uint Id = 851;
public uint MessageId
{
    get { return Id; }
}

public string receiver;
        

public ChatClientPrivateMessage()
{
}

public ChatClientPrivateMessage(string content, string receiver)
         : base(content)
        {
            this.receiver = receiver;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(receiver);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            receiver = reader.ReadUTF();
            

}


}


}