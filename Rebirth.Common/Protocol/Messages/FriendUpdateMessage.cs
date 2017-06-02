


















// Generated on 01/12/2017 03:53:00
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class FriendUpdateMessage : NetworkMessage
{

public const uint Id = 5924;
public uint MessageId
{
    get { return Id; }
}

public Types.FriendInformations friendUpdated;
        

public FriendUpdateMessage()
{
}

public FriendUpdateMessage(Types.FriendInformations friendUpdated)
        {
            this.friendUpdated = friendUpdated;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(friendUpdated.TypeId);
            friendUpdated.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

friendUpdated = ProtocolTypeManager.GetInstance<Types.FriendInformations>(reader.ReadShort());
            friendUpdated.Deserialize(reader);
            

}


}


}