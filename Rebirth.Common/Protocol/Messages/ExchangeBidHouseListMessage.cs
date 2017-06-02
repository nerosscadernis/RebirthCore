


















// Generated on 01/12/2017 03:53:02
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeBidHouseListMessage : NetworkMessage
{

public const uint Id = 5807;
public uint MessageId
{
    get { return Id; }
}

public uint id;
        

public ExchangeBidHouseListMessage()
{
}

public ExchangeBidHouseListMessage(uint id)
        {
            this.id = id;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)id);
            

}

public void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhShort();
            if (id < 0)
                throw new System.Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            

}


}


}