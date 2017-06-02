


















// Generated on 01/12/2017 03:52:54
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class PlayerStatusUpdateRequestMessage : NetworkMessage
{

public const uint Id = 6387;
public uint MessageId
{
    get { return Id; }
}

public Types.PlayerStatus status;
        

public PlayerStatusUpdateRequestMessage()
{
}

public PlayerStatusUpdateRequestMessage(Types.PlayerStatus status)
        {
            this.status = status;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(status.TypeId);
            status.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

status = ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadShort());
            status.Deserialize(reader);
            

}


}


}