


















// Generated on 01/12/2017 03:52:54
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class NumericWhoIsRequestMessage : NetworkMessage
{

public const uint Id = 6298;
public uint MessageId
{
    get { return Id; }
}

public double playerId;
        

public NumericWhoIsRequestMessage()
{
}

public NumericWhoIsRequestMessage(double playerId)
        {
            this.playerId = playerId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(playerId);
            

}

public void Deserialize(IDataReader reader)
{

playerId = reader.ReadVarUhLong();
            if (playerId < 0 || playerId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0 || playerId > 9.007199254740992E15");
            

}


}


}