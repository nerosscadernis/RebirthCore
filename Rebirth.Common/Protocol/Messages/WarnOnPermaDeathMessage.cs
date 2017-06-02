


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class WarnOnPermaDeathMessage : NetworkMessage
{

public const uint Id = 6512;
public uint MessageId
{
    get { return Id; }
}

public bool enable;
        

public WarnOnPermaDeathMessage()
{
}

public WarnOnPermaDeathMessage(bool enable)
        {
            this.enable = enable;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(enable);
            

}

public void Deserialize(IDataReader reader)
{

enable = reader.ReadBoolean();
            

}


}


}