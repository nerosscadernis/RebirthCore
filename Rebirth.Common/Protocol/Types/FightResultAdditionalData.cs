


















// Generated on 01/12/2017 03:53:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class FightResultAdditionalData : NetworkType
{

public const short Id = 191;
public virtual short TypeId
{
    get { return Id; }
}



public FightResultAdditionalData()
{
}



public virtual void Serialize(IDataWriter writer)
{



}

public virtual void Deserialize(IDataReader reader)
{



}


}


}