


















// Generated on 01/12/2017 03:53:03
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class MimicryObjectPreviewMessage : NetworkMessage
{

public const uint Id = 6458;
public uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem result;
        

public MimicryObjectPreviewMessage()
{
}

public MimicryObjectPreviewMessage(Types.ObjectItem result)
        {
            this.result = result;
        }
        

public void Serialize(IDataWriter writer)
{

result.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

result = new Types.ObjectItem();
            result.Deserialize(reader);
            

}


}


}