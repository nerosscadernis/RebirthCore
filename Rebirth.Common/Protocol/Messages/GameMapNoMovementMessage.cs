


















// Generated on 01/12/2017 03:52:55
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameMapNoMovementMessage : NetworkMessage
{

public const uint Id = 954;
public uint MessageId
{
    get { return Id; }
}

public short cellX;
        public short cellY;
        

public GameMapNoMovementMessage()
{
}

public GameMapNoMovementMessage(short cellX, short cellY)
        {
            this.cellX = cellX;
            this.cellY = cellY;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(cellX);
            writer.WriteShort(cellY);
            

}

public void Deserialize(IDataReader reader)
{

cellX = reader.ReadShort();
            cellY = reader.ReadShort();
            

}


}


}