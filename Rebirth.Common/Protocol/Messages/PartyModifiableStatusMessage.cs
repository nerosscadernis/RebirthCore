


















// Generated on 01/12/2017 03:52:59
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class PartyModifiableStatusMessage : AbstractPartyMessage
{

public const uint Id = 6277;
public uint MessageId
{
    get { return Id; }
}

public bool enabled;
        

public PartyModifiableStatusMessage()
{
}

public PartyModifiableStatusMessage(uint partyId, bool enabled)
         : base(partyId)
        {
            this.enabled = enabled;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(enabled);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            enabled = reader.ReadBoolean();
            

}


}


}