


















// Generated on 01/12/2017 03:52:52
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class AchievementRewardSuccessMessage : NetworkMessage
{

public const uint Id = 6376;
public uint MessageId
{
    get { return Id; }
}

public short achievementId;
        

public AchievementRewardSuccessMessage()
{
}

public AchievementRewardSuccessMessage(short achievementId)
        {
            this.achievementId = achievementId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(achievementId);
            

}

public void Deserialize(IDataReader reader)
{

achievementId = reader.ReadShort();
            

}


}


}