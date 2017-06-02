


















// Generated on 01/12/2017 03:52:54
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ChatAdminServerMessage : ChatServerMessage
{

public const uint Id = 6135;
public uint MessageId
{
    get { return Id; }
}



public ChatAdminServerMessage()
{
}

public ChatAdminServerMessage(sbyte channel, string content, int timestamp, string fingerprint, double senderId, string senderName, int senderAccountId)
         : base(channel, content, timestamp, fingerprint, senderId, senderName, senderAccountId)
        {
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}