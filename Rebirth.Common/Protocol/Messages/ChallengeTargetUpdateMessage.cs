


















// Generated on 01/12/2017 03:52:56
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ChallengeTargetUpdateMessage : NetworkMessage
{

public const uint Id = 6123;
public uint MessageId
{
    get { return Id; }
}

public uint challengeId;
        public double targetId;
        

public ChallengeTargetUpdateMessage()
{
}

public ChallengeTargetUpdateMessage(uint challengeId, double targetId)
        {
            this.challengeId = challengeId;
            this.targetId = targetId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)challengeId);
            writer.WriteDouble(targetId);
            

}

public void Deserialize(IDataReader reader)
{

challengeId = reader.ReadVarUhShort();
            if (challengeId < 0)
                throw new System.Exception("Forbidden value on challengeId = " + challengeId + ", it doesn't respect the following condition : challengeId < 0");
            targetId = reader.ReadDouble();
            if (targetId < -9.007199254740992E15 || targetId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on targetId = " + targetId + ", it doesn't respect the following condition : targetId < -9.007199254740992E15 || targetId > 9.007199254740992E15");
            

}


}


}