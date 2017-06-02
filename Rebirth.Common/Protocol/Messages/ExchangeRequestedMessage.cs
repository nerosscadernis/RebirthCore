


















// Generated on 01/12/2017 03:53:03
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeRequestedMessage : NetworkMessage
{

public const uint Id = 5522;
public uint MessageId
{
    get { return Id; }
}

public sbyte exchangeType;
        

public ExchangeRequestedMessage()
{
}

public ExchangeRequestedMessage(sbyte exchangeType)
        {
            this.exchangeType = exchangeType;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(exchangeType);
            

}

public void Deserialize(IDataReader reader)
{

exchangeType = reader.ReadSByte();
            

}


}


}