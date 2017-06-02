


















// Generated on 01/12/2017 03:53:02
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeCraftPaymentModificationRequestMessage : NetworkMessage
{

public const uint Id = 6579;
public uint MessageId
{
    get { return Id; }
}

public uint quantity;
        

public ExchangeCraftPaymentModificationRequestMessage()
{
}

public ExchangeCraftPaymentModificationRequestMessage(uint quantity)
        {
            this.quantity = quantity;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)quantity);
            

}

public void Deserialize(IDataReader reader)
{

quantity = reader.ReadVarUhInt();
            if (quantity < 0)
                throw new System.Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            

}


}


}