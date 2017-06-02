


















// Generated on 01/12/2017 03:53:02
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeObjectMoveKamaMessage : NetworkMessage
{

public const uint Id = 5520;
public uint MessageId
{
    get { return Id; }
}

public double quantity;
        

public ExchangeObjectMoveKamaMessage()
{
}

public ExchangeObjectMoveKamaMessage(int quantity)
        {
            this.quantity = quantity;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(quantity);
            

}

public void Deserialize(IDataReader reader)
{

quantity = reader.ReadVarLong();
            

}


}


}