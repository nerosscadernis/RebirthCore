


















// Generated on 01/12/2017 03:52:55
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameMapChangeOrientationMessage : NetworkMessage
{

public const uint Id = 946;
public uint MessageId
{
    get { return Id; }
}

public Types.ActorOrientation orientation;
        

public GameMapChangeOrientationMessage()
{
}

public GameMapChangeOrientationMessage(Types.ActorOrientation orientation)
        {
            this.orientation = orientation;
        }
        

public void Serialize(IDataWriter writer)
{

orientation.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

orientation = new Types.ActorOrientation();
            orientation.Deserialize(reader);
            

}


}


}