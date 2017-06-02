


















// Generated on 01/12/2017 03:53:04
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class PrismSetSabotagedRequestMessage : NetworkMessage
{

public const uint Id = 6468;
public uint MessageId
{
    get { return Id; }
}

public uint subAreaId;
        

public PrismSetSabotagedRequestMessage()
{
}

public PrismSetSabotagedRequestMessage(uint subAreaId)
        {
            this.subAreaId = subAreaId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)subAreaId);
            

}

public void Deserialize(IDataReader reader)
{

subAreaId = reader.ReadVarUhShort();
            if (subAreaId < 0)
                throw new System.Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            

}


}


}