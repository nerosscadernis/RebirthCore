


















// Generated on 01/12/2017 03:53:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class KrosmasterInventoryErrorMessage : NetworkMessage
{

public const uint Id = 6343;
public uint MessageId
{
    get { return Id; }
}

public sbyte reason;
        

public KrosmasterInventoryErrorMessage()
{
}

public KrosmasterInventoryErrorMessage(sbyte reason)
        {
            this.reason = reason;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(reason);
            

}

public void Deserialize(IDataReader reader)
{

reason = reader.ReadSByte();
            if (reason < 0)
                throw new System.Exception("Forbidden value on reason = " + reason + ", it doesn't respect the following condition : reason < 0");
            

}


}


}