


















// Generated on 01/12/2017 03:53:03
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeShopStockMultiMovementRemovedMessage : NetworkMessage
{

public const uint Id = 6037;
public uint MessageId
{
    get { return Id; }
}

public uint[] objectIdList;
        

public ExchangeShopStockMultiMovementRemovedMessage()
{
}

public ExchangeShopStockMultiMovementRemovedMessage(uint[] objectIdList)
        {
            this.objectIdList = objectIdList;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)objectIdList.Length);
            foreach (var entry in objectIdList)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            objectIdList = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectIdList[i] = reader.ReadVarUhInt();
            }
            

}


}


}