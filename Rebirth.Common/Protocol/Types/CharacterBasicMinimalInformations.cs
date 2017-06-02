


















// Generated on 01/12/2017 03:53:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class CharacterBasicMinimalInformations : AbstractCharacterInformation
{

public const short Id = 503;
public override short TypeId
{
    get { return Id; }
}

public string name;
        

public CharacterBasicMinimalInformations()
{
}

public CharacterBasicMinimalInformations(double id, string name)
         : base(id)
        {
            this.name = name;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            

}


}


}