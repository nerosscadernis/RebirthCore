


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayArenaFightAnswerMessage : NetworkMessage
{

public const uint Id = 6279;
public uint MessageId
{
    get { return Id; }
}

public int fightId;
        public bool accept;
        

public GameRolePlayArenaFightAnswerMessage()
{
}

public GameRolePlayArenaFightAnswerMessage(int fightId, bool accept)
        {
            this.fightId = fightId;
            this.accept = accept;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(fightId);
            writer.WriteBoolean(accept);
            

}

public void Deserialize(IDataReader reader)
{

fightId = reader.ReadInt();
            accept = reader.ReadBoolean();
            

}


}


}