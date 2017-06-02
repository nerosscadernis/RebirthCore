


















// Generated on 01/12/2017 03:53:02
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeBidHouseTypeMessage : NetworkMessage
{

public const uint Id = 5803;
public uint MessageId
{
    get { return Id; }
}

public uint type;
        

public ExchangeBidHouseTypeMessage()
{
}

public ExchangeBidHouseTypeMessage(uint type)
        {
            this.type = type;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)type);
            

}

public void Deserialize(IDataReader reader)
{

type = reader.ReadVarUhInt();
            if (type < 0)
                throw new System.Exception("Forbidden value on type = " + type + ", it doesn't respect the following condition : type < 0");
            

}


}


}