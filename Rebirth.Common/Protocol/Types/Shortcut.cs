


















// Generated on 01/12/2017 03:53:09
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class Shortcut : NetworkType
{

public const short Id = 369;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte slot;
        

public Shortcut()
{
}

public Shortcut(sbyte slot)
        {
            this.slot = slot;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSByte(slot);
            

}

public virtual void Deserialize(IDataReader reader)
{

slot = reader.ReadSByte();
            if (slot < 0 || slot > 99)
                throw new System.Exception("Forbidden value on slot = " + slot + ", it doesn't respect the following condition : slot < 0 || slot > 99");
            

}


}


}