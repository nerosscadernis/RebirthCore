


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class TeleportHavenBagAnswerMessage : NetworkMessage
{

public const uint Id = 6646;
public uint MessageId
{
    get { return Id; }
}

public bool accept;
        

public TeleportHavenBagAnswerMessage()
{
}

public TeleportHavenBagAnswerMessage(bool accept)
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