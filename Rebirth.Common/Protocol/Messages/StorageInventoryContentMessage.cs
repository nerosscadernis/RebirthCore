


















// Generated on 01/12/2017 03:53:04
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class StorageInventoryContentMessage : InventoryContentMessage
{

public const uint Id = 5646;
public uint MessageId
{
    get { return Id; }
}



public StorageInventoryContentMessage()
{
}

public StorageInventoryContentMessage(Types.ObjectItem[] objects, uint kamas)
         : base(objects, kamas)
        {
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}