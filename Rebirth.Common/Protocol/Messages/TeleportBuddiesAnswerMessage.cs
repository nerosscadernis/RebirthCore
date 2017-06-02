


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class TeleportBuddiesAnswerMessage : NetworkMessage
{

public const uint Id = 6294;
public uint MessageId
{
    get { return Id; }
}

public bool accept;
        

public TeleportBuddiesAnswerMessage()
{
}

public TeleportBuddiesAnswerMessage(bool accept)
        {
            this.accept = accept;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(accept);
            

}

public void Deserialize(IDataReader reader)
{

accept = reader.ReadBoolean();
            

}


}


}