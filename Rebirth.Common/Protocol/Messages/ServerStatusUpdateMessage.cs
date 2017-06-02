


















// Generated on 01/12/2017 03:52:52
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ServerStatusUpdateMessage : NetworkMessage
{

public const uint Id = 50;
public uint MessageId
{
    get { return Id; }
}

public Types.GameServerInformations server;
        

public ServerStatusUpdateMessage()
{
}

public ServerStatusUpdateMessage(Types.GameServerInformations server)
        {
            this.server = server;
        }
        

public void Serialize(IDataWriter writer)
{

server.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

server = new Types.GameServerInformations();
            server.Deserialize(reader);
            

}


}


}