


















// Generated on 01/12/2017 03:52:56
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class MountRidingMessage : NetworkMessage
{

public const uint Id = 5967;
public uint MessageId
{
    get { return Id; }
}

public bool isRiding;
        

public MountRidingMessage()
{
}

public MountRidingMessage(bool isRiding)
        {
            this.isRiding = isRiding;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(isRiding);
            

}

public void Deserialize(IDataReader reader)
{

isRiding = reader.ReadBoolean();
            

}


}


}