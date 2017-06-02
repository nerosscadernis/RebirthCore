


















// Generated on 01/12/2017 03:53:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class IdentifiedEntityDispositionInformations : EntityDispositionInformations
{

public const short Id = 107;
public override short TypeId
{
    get { return Id; }
}

public double id;
        

public IdentifiedEntityDispositionInformations()
{
}

public IdentifiedEntityDispositionInformations(short cellId, sbyte direction, double id)
         : base(cellId, direction)
        {
            this.id = id;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(id);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            id = reader.ReadDouble();
            if (id < -9.007199254740992E15 || id > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < -9.007199254740992E15 || id > 9.007199254740992E15");
            

}


}


}