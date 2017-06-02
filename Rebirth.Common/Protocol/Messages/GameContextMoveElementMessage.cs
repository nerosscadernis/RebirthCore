


















// Generated on 01/12/2017 03:52:55
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameContextMoveElementMessage : NetworkMessage
{

public const uint Id = 253;
public uint MessageId
{
    get { return Id; }
}

public Types.EntityMovementInformations movement;
        

public GameContextMoveElementMessage()
{
}

public GameContextMoveElementMessage(Types.EntityMovementInformations movement)
        {
            this.movement = movement;
        }
        

public void Serialize(IDataWriter writer)
{

movement.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

movement = new Types.EntityMovementInformations();
            movement.Deserialize(reader);
            

}


}


}