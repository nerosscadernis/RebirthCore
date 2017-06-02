


















// Generated on 01/12/2017 03:53:04
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class AreaFightModificatorUpdateMessage : NetworkMessage
{

public const uint Id = 6493;
public uint MessageId
{
    get { return Id; }
}

public int spellPairId;
        

public AreaFightModificatorUpdateMessage()
{
}

public AreaFightModificatorUpdateMessage(int spellPairId)
        {
            this.spellPairId = spellPairId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(spellPairId);
            

}

public void Deserialize(IDataReader reader)
{

spellPairId = reader.ReadInt();
            

}


}


}