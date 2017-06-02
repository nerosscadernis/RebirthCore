


















// Generated on 01/12/2017 03:53:00
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class FriendWarnOnConnectionStateMessage : NetworkMessage
{

public const uint Id = 5630;
public uint MessageId
{
    get { return Id; }
}

public bool enable;
        

public FriendWarnOnConnectionStateMessage()
{
}

public FriendWarnOnConnectionStateMessage(bool enable)
        {
            this.enable = enable;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(enable);
            

}

public void Deserialize(IDataReader reader)
{

enable = reader.ReadBoolean();
            

}


}


}