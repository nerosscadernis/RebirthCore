


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayShowChallengeMessage : NetworkMessage
{

public const uint Id = 301;
public uint MessageId
{
    get { return Id; }
}

public Types.FightCommonInformations commonsInfos;
        

public GameRolePlayShowChallengeMessage()
{
}

public GameRolePlayShowChallengeMessage(Types.FightCommonInformations commonsInfos)
        {
            this.commonsInfos = commonsInfos;
        }
        

public void Serialize(IDataWriter writer)
{

commonsInfos.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

commonsInfos = new Types.FightCommonInformations();
            commonsInfos.Deserialize(reader);
            

}


}


}