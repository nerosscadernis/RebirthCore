


















// Generated on 01/12/2017 03:52:52
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class AchievementDetailsRequestMessage : NetworkMessage
{

public const uint Id = 6380;
public uint MessageId
{
    get { return Id; }
}

public uint achievementId;
        

public AchievementDetailsRequestMessage()
{
}

public AchievementDetailsRequestMessage(uint achievementId)
        {
            this.achievementId = achievementId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)achievementId);
            

}

public void Deserialize(IDataReader reader)
{

achievementId = reader.ReadVarUhShort();
            if (achievementId < 0)
                throw new System.Exception("Forbidden value on achievementId = " + achievementId + ", it doesn't respect the following condition : achievementId < 0");
            

}


}


}