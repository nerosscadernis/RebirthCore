


















// Generated on 01/12/2017 03:53:02
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeBidHouseInListRemovedMessage : NetworkMessage
{

public const uint Id = 5950;
public uint MessageId
{
    get { return Id; }
}

public int itemUID;
        

public ExchangeBidHouseInListRemovedMessage()
{
}

public ExchangeBidHouseInListRemovedMessage(int itemUID)
        {
            this.itemUID = itemUID;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(itemUID);
            

}

public void Deserialize(IDataReader reader)
{

itemUID = reader.ReadInt();
            

}


}


}