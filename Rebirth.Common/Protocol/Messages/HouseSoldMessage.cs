


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class HouseSoldMessage : NetworkMessage
{

public const uint Id = 5737;
public uint MessageId
{
    get { return Id; }
}

public uint houseId;
        public uint realPrice;
        public string buyerName;
        

public HouseSoldMessage()
{
}

public HouseSoldMessage(uint houseId, uint realPrice, string buyerName)
        {
            this.houseId = houseId;
            this.realPrice = realPrice;
            this.buyerName = buyerName;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)houseId);
            writer.WriteVarInt((int)realPrice);
            writer.WriteUTF(buyerName);
            

}

public void Deserialize(IDataReader reader)
{

houseId = reader.ReadVarUhInt();
            if (houseId < 0)
                throw new System.Exception("Forbidden value on houseId = " + houseId + ", it doesn't respect the following condition : houseId < 0");
            realPrice = reader.ReadVarUhInt();
            if (realPrice < 0)
                throw new System.Exception("Forbidden value on realPrice = " + realPrice + ", it doesn't respect the following condition : realPrice < 0");
            buyerName = reader.ReadUTF();
            

}


}


}