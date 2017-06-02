


















// Generated on 01/12/2017 03:52:55
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightReadyMessage : NetworkMessage
{

public const uint Id = 708;
public uint MessageId
{
    get { return Id; }
}

public bool isReady;
        

public GameFightReadyMessage()
{
}

public GameFightReadyMessage(bool isReady)
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