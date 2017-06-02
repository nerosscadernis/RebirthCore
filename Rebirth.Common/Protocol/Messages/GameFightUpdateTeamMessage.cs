


















// Generated on 01/12/2017 03:52:56
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightUpdateTeamMessage : NetworkMessage
{

public const uint Id = 5572;
public uint MessageId
{
    get { return Id; }
}

public short fightId;
        public Types.FightTeamInformations team;
        

public GameFightUpdateTeamMessage()
{
}

public GameFightUpdateTeamMessage(short fightId, Types.FightTeamInformations team)
        {
            this.fightId = fightId;
            this.team = team;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(fightId);
            team.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

fightId = reader.ReadShort();
            if (fightId < 0)
                throw new System.Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            team = new Types.FightTeamInformations();
            team.Deserialize(reader);
            

}


}


}