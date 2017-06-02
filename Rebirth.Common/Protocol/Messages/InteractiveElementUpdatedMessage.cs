


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class InteractiveElementUpdatedMessage : NetworkMessage
{

public const uint Id = 5708;
public uint MessageId
{
    get { return Id; }
}

public Types.InteractiveElement interactiveElement;
        

public InteractiveElementUpdatedMessage()
{
}

public InteractiveElementUpdatedMessage(Types.InteractiveElement interactiveElement)
        {
            this.interactiveElement = interactiveElement;
        }
        

public void Serialize(IDataWriter writer)
{

interactiveElement.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

interactiveElement = new Types.InteractiveElement();
            interactiveElement.Deserialize(reader);
            

}


}


}