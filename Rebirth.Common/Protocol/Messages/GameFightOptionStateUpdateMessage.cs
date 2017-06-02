


















// Generated on 01/12/2017 03:52:55
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightOptionStateUpdateMessage : NetworkMessage
{

public const uint Id = 5927;
public uint MessageId
{
    get { return Id; }
}

public short fightId;
        public sbyte teamId;
        public sbyte option;
        public bool state;
        

public GameFightOptionStateUpdateMessage()
{
}

public GameFightOptionStateUpdateMessage(short fightId, sbyte teamId, sbyte option, bool state)
        {
            this.fightId = fightId;
            this.teamId = teamId;
            this.option = option;
            this.state = state;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(fightId);
            writer.WriteSByte(teamId);
            writer.WriteSByte(option);
            writer.WriteBoolean(state);
            

}

public void Deserialize(IDataReader reader)
{

fightId = reader.ReadShort();
            if (fightId < 0)
                throw new System.Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            teamId = reader.ReadSByte();
            if (teamId < 0)
                throw new System.Exception("Forbidden value on teamId = " + teamId + ", it doesn't respect the following condition : teamId < 0");
            option = reader.ReadSByte();
            if (option < 0)
                throw new System.Exception("Forbidden value on option = " + option + ", it doesn't respect the following condition : option < 0");
            state = reader.ReadBoolean();
            

}


}


}