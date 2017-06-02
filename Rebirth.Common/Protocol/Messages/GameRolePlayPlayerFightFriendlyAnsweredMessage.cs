


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayPlayerFightFriendlyAnsweredMessage : NetworkMessage
{

public const uint Id = 5733;
public uint MessageId
{
    get { return Id; }
}

public int fightId;
        public double sourceId;
        public double targetId;
        public bool accept;
        

public GameRolePlayPlayerFightFriendlyAnsweredMessage()
{
}

public GameRolePlayPlayerFightFriendlyAnsweredMessage(int fightId, double sourceId, double targetId, bool accept)
        {
            this.fightId = fightId;
            this.sourceId = sourceId;
            this.targetId = targetId;
            this.accept = accept;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(fightId);
            writer.WriteVarLong(sourceId);
            writer.WriteVarLong(targetId);
            writer.WriteBoolean(accept);
            

}

public void Deserialize(IDataReader reader)
{

fightId = reader.ReadInt();
            sourceId = reader.ReadVarUhLong();
            if (sourceId < 0 || sourceId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on sourceId = " + sourceId + ", it doesn't respect the following condition : sourceId < 0 || sourceId > 9.007199254740992E15");
            targetId = reader.ReadVarUhLong();
            if (targetId < 0 || targetId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on targetId = " + targetId + ", it doesn't respect the following condition : targetId < 0 || targetId > 9.007199254740992E15");
            accept = reader.ReadBoolean();
            

}


}


}