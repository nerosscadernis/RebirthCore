


















// Generated on 01/12/2017 03:53:04
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class SymbioticObjectAssociatedMessage : NetworkMessage
{

public const uint Id = 6527;
public uint MessageId
{
    get { return Id; }
}

public uint hostUID;
        

public SymbioticObjectAssociatedMessage()
{
}

public SymbioticObjectAssociatedMessage(uint hostUID)
        {
            this.hostUID = hostUID;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)hostUID);
            

}

public void Deserialize(IDataReader reader)
{

hostUID = reader.ReadVarUhInt();
            if (hostUID < 0)
                throw new System.Exception("Forbidden value on hostUID = " + hostUID + ", it doesn't respect the following condition : hostUID < 0");
            

}


}


}