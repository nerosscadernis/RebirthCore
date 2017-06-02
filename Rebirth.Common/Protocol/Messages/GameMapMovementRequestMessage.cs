


















// Generated on 01/12/2017 03:52:55
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameMapMovementRequestMessage : NetworkMessage
{

public const uint Id = 950;
public uint MessageId
{
    get { return Id; }
}

public short[] keyMovements;
        public int mapId;
        

public GameMapMovementRequestMessage()
{
}

public GameMapMovementRequestMessage(short[] keyMovements, int mapId)
        {
            this.keyMovements = keyMovements;
            this.mapId = mapId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)keyMovements.Length);
            foreach (var entry in keyMovements)
            {
                 writer.WriteShort(entry);
            }
            writer.WriteInt(mapId);
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            keyMovements = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 keyMovements[i] = reader.ReadShort();
            }
            mapId = reader.ReadInt();
            if (mapId < 0)
                throw new System.Exception("Forbidden value on mapId = " + mapId + ", it doesn't respect the following condition : mapId < 0");
            

}


}


}