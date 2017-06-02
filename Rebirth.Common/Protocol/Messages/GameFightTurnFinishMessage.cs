


















// Generated on 01/12/2017 03:52:56
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightTurnFinishMessage : NetworkMessage
{

public const uint Id = 718;
public uint MessageId
{
    get { return Id; }
}

public bool isAfk;
        

public GameFightTurnFinishMessage()
{
}

public GameFightTurnFinishMessage(bool isAfk)
        {
            this.isAfk = isAfk;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(isAfk);
            

}

public void Deserialize(IDataReader reader)
{

isAfk = reader.ReadBoolean();
            

}


}


}