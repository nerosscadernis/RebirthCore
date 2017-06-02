


















// Generated on 01/12/2017 03:53:04
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class AccessoryPreviewMessage : NetworkMessage
{

public const uint Id = 6517;
public uint MessageId
{
    get { return Id; }
}

public Types.EntityLook look;
        

public AccessoryPreviewMessage()
{
}

public AccessoryPreviewMessage(Types.EntityLook look)
        {
            this.look = look;
        }
        

public void Serialize(IDataWriter writer)
{

look.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

look = new Types.EntityLook();
            look.Deserialize(reader);
            

}


}


}