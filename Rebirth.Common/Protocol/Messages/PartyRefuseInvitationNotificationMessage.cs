


















// Generated on 01/12/2017 03:52:59
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class PartyRefuseInvitationNotificationMessage : AbstractPartyEventMessage
{

public const uint Id = 5596;
public uint MessageId
{
    get { return Id; }
}

public double guestId;
        

public PartyRefuseInvitationNotificationMessage()
{
}

public PartyRefuseInvitationNotificationMessage(uint partyId, double guestId)
         : base(partyId)
        {
            this.guestId = guestId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(guestId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            guestId = reader.ReadVarUhLong();
            if (guestId < 0 || guestId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on guestId = " + guestId + ", it doesn't respect the following condition : guestId < 0 || guestId > 9.007199254740992E15");
            

}


}


}