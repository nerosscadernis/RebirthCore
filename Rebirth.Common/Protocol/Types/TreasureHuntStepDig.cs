


















// Generated on 01/12/2017 03:53:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class TreasureHuntStepDig : TreasureHuntStep
{

public const short Id = 465;
public override short TypeId
{
    get { return Id; }
}



public TreasureHuntStepDig()
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