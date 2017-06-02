


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayArenaFighterStatusMessage : NetworkMessage
{

public const uint Id = 6281;
public uint MessageId
{
    get { return Id; }
}

public int fightId;
        public int playerId;
        public bool accepted;
        

public GameRolePlayArenaFighterStatusMessage()
{
}

public GameRolePlayArenaFighterStatusMessage(int fightId, int playerId, bool accepted)
        {
            this.fightId = fightId;
            this.playerId = playerId;
            this.accepted = accepted;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(fightId);
            writer.WriteInt(playerId);
            writer.WriteBoolean(accepted);
            

}

public void Deserialize(IDataReader reader)
{

fightId = reader.ReadInt();
            playerId = reader.ReadInt();
            accepted = reader.ReadBoolean();
            

}


}


}