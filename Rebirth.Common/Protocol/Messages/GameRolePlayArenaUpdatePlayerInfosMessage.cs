


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayArenaUpdatePlayerInfosMessage : NetworkMessage
{

public const uint Id = 6301;
public uint MessageId
{
    get { return Id; }
}

public Types.ArenaRankInfos solo;
        

public GameRolePlayArenaUpdatePlayerInfosMessage()
{
}

public GameRolePlayArenaUpdatePlayerInfosMessage(Types.ArenaRankInfos solo)
        {
            this.solo = solo;
        }
        

public void Serialize(IDataWriter writer)
{

solo.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

solo = new Types.ArenaRankInfos();
            solo.Deserialize(reader);
            

}


}


}