


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayRemoveChallengeMessage : NetworkMessage
{

public const uint Id = 300;
public uint MessageId
{
    get { return Id; }
}

public int fightId;
        

public GameRolePlayRemoveChallengeMessage()
{
}

public GameRolePlayRemoveChallengeMessage(int fightId)
        {
            this.fightId = fightId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(fightId);
            

}

public void Deserialize(IDataReader reader)
{

fightId = reader.ReadInt();
            

}


}


}