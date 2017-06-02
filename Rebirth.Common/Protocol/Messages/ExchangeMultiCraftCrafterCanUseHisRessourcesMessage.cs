


















// Generated on 01/12/2017 03:53:03
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeMultiCraftCrafterCanUseHisRessourcesMessage : NetworkMessage
{

public const uint Id = 6020;
public uint MessageId
{
    get { return Id; }
}

public bool allowed;
        

public ExchangeMultiCraftCrafterCanUseHisRessourcesMessage()
{
}

public ExchangeMultiCraftCrafterCanUseHisRessourcesMessage(bool allowed)
        {
            this.allowed = allowed;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(allowed);
            

}

public void Deserialize(IDataReader reader)
{

allowed = reader.ReadBoolean();
            

}


}


}