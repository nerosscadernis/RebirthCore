


















// Generated on 01/12/2017 03:53:05
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class PrismUseRequestMessage : NetworkMessage
{

public const uint Id = 6041;
public uint MessageId
{
    get { return Id; }
}

public sbyte moduleToUse;
        

public PrismUseRequestMessage()
{
}

public PrismUseRequestMessage(sbyte moduleToUse)
        {
            this.moduleToUse = moduleToUse;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(moduleToUse);
            

}

public void Deserialize(IDataReader reader)
{

moduleToUse = reader.ReadSByte();
            if (moduleToUse < 0)
                throw new System.Exception("Forbidden value on moduleToUse = " + moduleToUse + ", it doesn't respect the following condition : moduleToUse < 0");
            

}


}


}