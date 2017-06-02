


















// Generated on 01/12/2017 03:53:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class MapCoordinates : NetworkType
{

public const short Id = 174;
public virtual short TypeId
{
    get { return Id; }
}

public short worldX;
        public short worldY;
        

public MapCoordinates()
{
}

public MapCoordinates(short worldX, short worldY)
        {
            this.worldX = worldX;
            this.worldY = worldY;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            

}

public virtual void Deserialize(IDataReader reader)
{

worldX = reader.ReadShort();
            if (worldX < -255 || worldX > 255)
                throw new System.Exception("Forbidden value on worldX = " + worldX + ", it doesn't respect the following condition : worldX < -255 || worldX > 255");
            worldY = reader.ReadShort();
            if (worldY < -255 || worldY > 255)
                throw new System.Exception("Forbidden value on worldY = " + worldY + ", it doesn't respect the following condition : worldY < -255 || worldY > 255");
            

}


}


}