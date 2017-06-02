


















// Generated on 01/12/2017 03:52:55
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightNewRoundMessage : NetworkMessage
{

public const uint Id = 6239;
public uint MessageId
{
    get { return Id; }
}

public uint roundNumber;
        

public GameFightNewRoundMessage()
{
}

public GameFightNewRoundMessage(uint roundNumber)
        {
            this.roundNumber = roundNumber;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)roundNumber);
            

}

public void Deserialize(IDataReader reader)
{

roundNumber = reader.ReadVarUhInt();
            if (roundNumber < 0)
                throw new System.Exception("Forbidden value on roundNumber = " + roundNumber + ", it doesn't respect the following condition : roundNumber < 0");
            

}


}


}