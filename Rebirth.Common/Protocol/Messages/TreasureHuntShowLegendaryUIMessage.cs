


















// Generated on 01/12/2017 03:52:59
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class TreasureHuntShowLegendaryUIMessage : NetworkMessage
{

public const uint Id = 6498;
public uint MessageId
{
    get { return Id; }
}

public uint[] availableLegendaryIds;
        

public TreasureHuntShowLegendaryUIMessage()
{
}

public TreasureHuntShowLegendaryUIMessage(uint[] availableLegendaryIds)
        {
            this.availableLegendaryIds = availableLegendaryIds;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)availableLegendaryIds.Length);
            foreach (var entry in availableLegendaryIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            availableLegendaryIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 availableLegendaryIds[i] = reader.ReadVarUhShort();
            }
            

}


}


}