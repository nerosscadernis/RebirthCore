


















// Generated on 01/12/2017 03:53:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ActorOrientation : NetworkType
{

public const short Id = 353;
public virtual short TypeId
{
    get { return Id; }
}

public double id;
        public sbyte direction;
        

public ActorOrientation()
{
}

public ActorOrientation(double id, sbyte direction)
        {
            this.id = id;
            this.direction = direction;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteDouble(id);
            writer.WriteSByte(direction);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadDouble();
            if (id < -9.007199254740992E15 || id > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < -9.007199254740992E15 || id > 9.007199254740992E15");
            direction = reader.ReadSByte();
            if (direction < 0)
                throw new System.Exception("Forbidden value on direction = " + direction + ", it doesn't respect the following condition : direction < 0");
            

}


}


}