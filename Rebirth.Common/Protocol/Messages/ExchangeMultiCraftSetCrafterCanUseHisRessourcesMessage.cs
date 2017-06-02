


















// Generated on 01/12/2017 03:53:03
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage : NetworkMessage
{

public const uint Id = 6021;
public uint MessageId
{
    get { return Id; }
}

public bool allow;
        

public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage()
{
}

public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage(bool allow)
        {
            this.allow = allow;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(allow);
            

}

public void Deserialize(IDataReader reader)
{

allow = reader.ReadBoolean();
            

}


}


}