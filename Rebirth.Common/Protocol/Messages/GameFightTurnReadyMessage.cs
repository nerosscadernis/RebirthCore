


















// Generated on 01/12/2017 03:52:56
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightTurnReadyMessage : NetworkMessage
{

public const uint Id = 716;
public uint MessageId
{
    get { return Id; }
}

public bool isReady;
        

public GameFightTurnReadyMessage()
{
}

public GameFightTurnReadyMessage(bool isReady)
        {
            this.isReady = isReady;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(isReady);
            

}

public void Deserialize(IDataReader reader)
{

isReady = reader.ReadBoolean();
            

}


}


}