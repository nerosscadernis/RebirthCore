


















// Generated on 01/12/2017 03:52:59
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class PortalUseRequestMessage : NetworkMessage
{

public const uint Id = 6492;
public uint MessageId
{
    get { return Id; }
}

public uint portalId;
        

public PortalUseRequestMessage()
{
}

public PortalUseRequestMessage(uint portalId)
        {
            this.portalId = portalId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)portalId);
            

}

public void Deserialize(IDataReader reader)
{

portalId = reader.ReadVarUhInt();
            if (portalId < 0)
                throw new System.Exception("Forbidden value on portalId = " + portalId + ", it doesn't respect the following condition : portalId < 0");
            

}


}


}