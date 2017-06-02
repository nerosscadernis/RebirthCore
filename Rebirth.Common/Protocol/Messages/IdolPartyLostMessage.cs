


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class IdolPartyLostMessage : NetworkMessage
{

public const uint Id = 6580;
public uint MessageId
{
    get { return Id; }
}

public uint idolId;
        

public IdolPartyLostMessage()
{
}

public IdolPartyLostMessage(uint idolId)
        {
            this.idolId = idolId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)idolId);
            

}

public void Deserialize(IDataReader reader)
{

idolId = reader.ReadVarUhShort();
            if (idolId < 0)
                throw new System.Exception("Forbidden value on idolId = " + idolId + ", it doesn't respect the following condition : idolId < 0");
            

}


}


}