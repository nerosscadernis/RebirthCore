


















// Generated on 01/12/2017 03:53:02
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class KamasUpdateMessage : NetworkMessage
{

public const uint Id = 5537;
public uint MessageId
{
    get { return Id; }
}

public int kamasTotal;
        

public KamasUpdateMessage()
{
}

public KamasUpdateMessage(int kamasTotal)
        {
            this.kamasTotal = kamasTotal;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)kamasTotal);
            

}

public void Deserialize(IDataReader reader)
{

kamasTotal = reader.ReadVarInt();
            

}


}


}