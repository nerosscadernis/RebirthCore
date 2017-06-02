


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class HouseBuyResultMessage : NetworkMessage
{

public const uint Id = 5735;
public uint MessageId
{
    get { return Id; }
}

public uint houseId;
        public bool bought;
        public uint realPrice;
        

public HouseBuyResultMessage()
{
}

public HouseBuyResultMessage(uint houseId, bool bought, uint realPrice)
        {
            this.houseId = houseId;
            this.bought = bought;
            this.realPrice = realPrice;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)houseId);
            writer.WriteBoolean(bought);
            writer.WriteVarInt((int)realPrice);
            

}

public void Deserialize(IDataReader reader)
{

houseId = reader.ReadVarUhInt();
            if (houseId < 0)
                throw new System.Exception("Forbidden value on houseId = " + houseId + ", it doesn't respect the following condition : houseId < 0");
            bought = reader.ReadBoolean();
            realPrice = reader.ReadVarUhInt();
            if (realPrice < 0)
                throw new System.Exception("Forbidden value on realPrice = " + realPrice + ", it doesn't respect the following condition : realPrice < 0");
            

}


}


}