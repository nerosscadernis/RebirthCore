


















// Generated on 01/12/2017 03:52:54
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class PlayerStatusUpdateMessage : NetworkMessage
{

public const uint Id = 6386;
public uint MessageId
{
    get { return Id; }
}

public int accountId;
        public double playerId;
        public Types.PlayerStatus status;
        

public PlayerStatusUpdateMessage()
{
}

public PlayerStatusUpdateMessage(int accountId, double playerId, Types.PlayerStatus status)
        {
            this.accountId = accountId;
            this.playerId = playerId;
            this.status = status;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(accountId);
            writer.WriteVarLong(playerId);
            writer.WriteShort(status.TypeId);
            status.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

accountId = reader.ReadInt();
            if (accountId < 0)
                throw new System.Exception("Forbidden value on accountId = " + accountId + ", it doesn't respect the following condition : accountId < 0");
            playerId = reader.ReadVarUhLong();
            if (playerId < 0 || playerId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0 || playerId > 9.007199254740992E15");
            status = ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadShort());
            status.Deserialize(reader);
            

}


}


}