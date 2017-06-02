


















// Generated on 01/12/2017 03:53:03
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GoldAddedMessage : NetworkMessage
{

public const uint Id = 6030;
public uint MessageId
{
    get { return Id; }
}

public Types.GoldItem gold;
        

public GoldAddedMessage()
{
}

public GoldAddedMessage(Types.GoldItem gold)
        {
            this.gold = gold;
        }
        

public void Serialize(IDataWriter writer)
{

gold.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

gold = new Types.GoldItem();
            gold.Deserialize(reader);
            

}


}


}