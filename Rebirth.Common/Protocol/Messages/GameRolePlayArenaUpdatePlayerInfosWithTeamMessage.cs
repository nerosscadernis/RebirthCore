


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayArenaUpdatePlayerInfosWithTeamMessage : GameRolePlayArenaUpdatePlayerInfosMessage
{

public const uint Id = 6640;
public uint MessageId
{
    get { return Id; }
}

public Types.ArenaRankInfos team;
        

public GameRolePlayArenaUpdatePlayerInfosWithTeamMessage()
{
}

public GameRolePlayArenaUpdatePlayerInfosWithTeamMessage(Types.ArenaRankInfos solo, Types.ArenaRankInfos team)
         : base(solo)
        {
            this.team = team;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            team.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            team = new Types.ArenaRankInfos();
            team.Deserialize(reader);
            

}


}


}