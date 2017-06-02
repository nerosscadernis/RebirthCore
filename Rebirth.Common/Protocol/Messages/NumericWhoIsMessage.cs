


















// Generated on 01/12/2017 03:52:54
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class NumericWhoIsMessage : NetworkMessage
{

public const uint Id = 6297;
public uint MessageId
{
    get { return Id; }
}

public double playerId;
        public int accountId;
        

public NumericWhoIsMessage()
{
}

public NumericWhoIsMessage(double playerId, int accountId)
        {
            this.playerId = playerId;
            this.accountId = accountId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(playerId);
            writer.WriteInt(accountId);
            

}

public void Deserialize(IDataReader reader)
{

playerId = reader.ReadVarUhLong();
            if (playerId < 0 || playerId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0 || playerId > 9.007199254740992E15");
            accountId = reader.ReadInt();
            if (accountId < 0)
                throw new System.Exception("Forbidden value on accountId = " + accountId + ", it doesn't respect the following condition : accountId < 0");
            

}


}


}