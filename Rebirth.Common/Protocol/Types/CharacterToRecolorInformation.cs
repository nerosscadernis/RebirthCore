


















// Generated on 01/12/2017 03:53:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class CharacterToRecolorInformation : AbstractCharacterToRefurbishInformation
{

public const short Id = 212;
public override short TypeId
{
    get { return Id; }
}



public CharacterToRecolorInformation()
{
}

public CharacterToRecolorInformation(double id, int[] colors, uint cosmeticId)
         : base(id, colors, cosmeticId)
        {
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}