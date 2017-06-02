


















// Generated on 01/12/2017 03:53:02
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeCraftCountRequestMessage : NetworkMessage
{

public const uint Id = 6597;
public uint MessageId
{
    get { return Id; }
}

public int count;
        

public ExchangeCraftCountRequestMessage()
{
}

public ExchangeCraftCountRequestMessage(int count)
        {
            this.count = count;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)count);
            

}

public void Deserialize(IDataReader reader)
{

count = reader.ReadVarInt();
            

}


}


}