


















// Generated on 01/12/2017 03:52:58
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class LockableStateUpdateAbstractMessage : NetworkMessage
{

public const uint Id = 5671;
public uint MessageId
{
    get { return Id; }
}

public bool locked;
        

public LockableStateUpdateAbstractMessage()
{
}

public LockableStateUpdateAbstractMessage(bool locked)
        {
            this.locked = locked;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(locked);
            

}

public void Deserialize(IDataReader reader)
{

locked = reader.ReadBoolean();
            

}


}


}