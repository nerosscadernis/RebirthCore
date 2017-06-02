


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class HouseSellRequestMessage : NetworkMessage
{

public const uint Id = 5697;
public uint MessageId
{
    get { return Id; }
}

public uint amount;
        public bool forSale;
        

public HouseSellRequestMessage()
{
}

public HouseSellRequestMessage(uint amount, bool forSale)
        {
            this.amount = amount;
            this.forSale = forSale;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)amount);
            writer.WriteBoolean(forSale);
            

}

public void Deserialize(IDataReader reader)
{

amount = reader.ReadVarUhInt();
            if (amount < 0)
                throw new System.Exception("Forbidden value on amount = " + amount + ", it doesn't respect the following condition : amount < 0");
            forSale = reader.ReadBoolean();
            

}


}


}