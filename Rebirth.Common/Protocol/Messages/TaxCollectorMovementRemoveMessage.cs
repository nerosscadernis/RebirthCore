


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class TaxCollectorMovementRemoveMessage : NetworkMessage
{

public const uint Id = 5915;
public uint MessageId
{
    get { return Id; }
}

public int collectorId;
        

public TaxCollectorMovementRemoveMessage()
{
}

public TaxCollectorMovementRemoveMessage(int collectorId)
        {
            this.collectorId = collectorId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(collectorId);
            

}

public void Deserialize(IDataReader reader)
{

collectorId = reader.ReadInt();
            

}


}


}