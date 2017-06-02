


















// Generated on 01/12/2017 03:53:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class EntityDispositionInformations : NetworkType
{

public const short Id = 60;
public virtual short TypeId
{
    get { return Id; }
}

public short cellId;
        public sbyte direction;
        

public EntityDispositionInformations()
{
}

public EntityDispositionInformations(short cellId, sbyte direction)
        {
            this.cellId = cellId;
            this.direction = direction;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteShort(cellId);
            writer.WriteSByte(direction);
            

}

public virtual void Deserialize(IDataReader reader)
{

cellId = reader.ReadShort();
            if (cellId < -1 || cellId > 559)
                throw new System.Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < -1 || cellId > 559");
            direction = reader.ReadSByte();
            if (direction < 0)
                throw new System.Exception("Forbidden value on direction = " + direction + ", it doesn't respect the following condition : direction < 0");
            

}


}


}