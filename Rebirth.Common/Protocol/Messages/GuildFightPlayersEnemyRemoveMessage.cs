


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildFightPlayersEnemyRemoveMessage : NetworkMessage
{

public const uint Id = 5929;
public uint MessageId
{
    get { return Id; }
}

public int fightId;
        public double playerId;
        

public GuildFightPlayersEnemyRemoveMessage()
{
}

public GuildFightPlayersEnemyRemoveMessage(int fightId, double playerId)
        {
            this.fightId = fightId;
            this.playerId = playerId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(fightId);
            writer.WriteVarLong(playerId);
            

}

public void Deserialize(IDataReader reader)
{

fightId = reader.ReadInt();
            if (fightId < 0)
                throw new System.Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            playerId = reader.ReadVarUhLong();
            if (playerId < 0 || playerId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0 || playerId > 9.007199254740992E15");
            

}


}


}