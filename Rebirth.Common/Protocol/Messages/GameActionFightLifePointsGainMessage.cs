


















// Generated on 01/12/2017 03:52:53
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionFightLifePointsGainMessage : AbstractGameActionMessage
{

public const uint Id = 6311;
public uint MessageId
{
    get { return Id; }
}

public double targetId;
        public uint delta;
        

public GameActionFightLifePointsGainMessage()
{
}

public GameActionFightLifePointsGainMessage(uint actionId, double sourceId, double targetId, uint delta)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.delta = delta;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteVarInt((int)delta);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadDouble();
            if (targetId < -9.007199254740992E15 || targetId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on targetId = " + targetId + ", it doesn't respect the following condition : targetId < -9.007199254740992E15 || targetId > 9.007199254740992E15");
            delta = reader.ReadVarUhInt();
            if (delta < 0)
                throw new System.Exception("Forbidden value on delta = " + delta + ", it doesn't respect the following condition : delta < 0");
            

}


}


}