


















// Generated on 01/12/2017 03:53:02
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ZaapRespawnUpdatedMessage : NetworkMessage
{

public const uint Id = 6571;
public uint MessageId
{
    get { return Id; }
}

public int mapId;
        

public ZaapRespawnUpdatedMessage()
{
}

public ZaapRespawnUpdatedMessage(int mapId)
        {
            this.mapId = mapId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(mapId);
            

}

public void Deserialize(IDataReader reader)
{

mapId = reader.ReadInt();
            if (mapId < 0)
                throw new System.Exception("Forbidden value on mapId = " + mapId + ", it doesn't respect the following condition : mapId < 0");
            

}


}


}