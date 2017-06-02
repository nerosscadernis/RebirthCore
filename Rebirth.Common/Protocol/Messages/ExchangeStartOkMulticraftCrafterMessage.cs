


















// Generated on 01/12/2017 03:53:03
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeStartOkMulticraftCrafterMessage : NetworkMessage
{

public const uint Id = 5818;
public uint MessageId
{
    get { return Id; }
}

public uint skillId;
        

public ExchangeStartOkMulticraftCrafterMessage()
{
}

public ExchangeStartOkMulticraftCrafterMessage(uint skillId)
        {
            this.skillId = skillId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)skillId);
            

}

public void Deserialize(IDataReader reader)
{

skillId = reader.ReadVarUhInt();
            if (skillId < 0)
                throw new System.Exception("Forbidden value on skillId = " + skillId + ", it doesn't respect the following condition : skillId < 0");
            

}


}


}