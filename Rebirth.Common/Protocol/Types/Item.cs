


















// Generated on 01/12/2017 03:53:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class Item : NetworkType
{

public const short Id = 7;
public virtual short TypeId
{
    get { return Id; }
}



public Item()
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