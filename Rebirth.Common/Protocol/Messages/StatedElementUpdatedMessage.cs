


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class StatedElementUpdatedMessage : NetworkMessage
{

public const uint Id = 5709;
public uint MessageId
{
    get { return Id; }
}

public Types.StatedElement statedElement;
        

public StatedElementUpdatedMessage()
{
}

public StatedElementUpdatedMessage(Types.StatedElement statedElement)
        {
            this.statedElement = statedElement;
        }
        

public void Serialize(IDataWriter writer)
{

statedElement.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

statedElement = new Types.StatedElement();
            statedElement.Deserialize(reader);
            

}


}


}