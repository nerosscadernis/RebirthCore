


















// Generated on 01/12/2017 03:53:04
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class StorageKamasUpdateMessage : NetworkMessage
{

public const uint Id = 5645;
public uint MessageId
{
    get { return Id; }
}

public int kamasTotal;
        

public StorageKamasUpdateMessage()
{
}

public StorageKamasUpdateMessage(int kamasTotal)
        {
            this.kamasTotal = kamasTotal;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(kamasTotal);
            

}

public void Deserialize(IDataReader reader)
{

kamasTotal = (int)reader.ReadVarLong();
            

}


}


}