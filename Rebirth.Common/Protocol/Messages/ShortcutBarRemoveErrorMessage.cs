


















// Generated on 01/12/2017 03:53:05
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ShortcutBarRemoveErrorMessage : NetworkMessage
{

public const uint Id = 6222;
public uint MessageId
{
    get { return Id; }
}

public sbyte error;
        

public ShortcutBarRemoveErrorMessage()
{
}

public ShortcutBarRemoveErrorMessage(sbyte error)
        {
            this.error = error;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(error);
            

}

public void Deserialize(IDataReader reader)
{

error = reader.ReadSByte();
            if (error < 0)
                throw new System.Exception("Forbidden value on error = " + error + ", it doesn't respect the following condition : error < 0");
            

}


}


}