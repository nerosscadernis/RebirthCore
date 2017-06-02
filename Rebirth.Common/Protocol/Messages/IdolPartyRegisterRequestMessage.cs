


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class IdolPartyRegisterRequestMessage : NetworkMessage
{

public const uint Id = 6582;
public uint MessageId
{
    get { return Id; }
}

public bool register;
        

public IdolPartyRegisterRequestMessage()
{
}

public IdolPartyRegisterRequestMessage(bool register)
        {
            this.register = register;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(register);
            

}

public void Deserialize(IDataReader reader)
{

register = reader.ReadBoolean();
            

}


}


}