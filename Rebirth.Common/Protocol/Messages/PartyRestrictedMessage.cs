


















// Generated on 01/12/2017 03:52:59
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class PartyRestrictedMessage : AbstractPartyMessage
{

public const uint Id = 6175;
public uint MessageId
{
    get { return Id; }
}

public bool restricted;
        

public PartyRestrictedMessage()
{
}

public PartyRestrictedMessage(uint partyId, bool restricted)
         : base(partyId)
        {
            this.restricted = restricted;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(restricted);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            restricted = reader.ReadBoolean();
            

}


}


}