


















// Generated on 01/12/2017 03:52:58
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class PartyCancelInvitationNotificationMessage : AbstractPartyEventMessage
{

public const uint Id = 6251;
public uint MessageId
{
    get { return Id; }
}

public double cancelerId;
        public double guestId;
        

public PartyCancelInvitationNotificationMessage()
{
}

public PartyCancelInvitationNotificationMessage(uint partyId, double cancelerId, double guestId)
         : base(partyId)
        {
            this.cancelerId = cancelerId;
            this.guestId = guestId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(cancelerId);
            writer.WriteVarLong(guestId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            cancelerId = reader.ReadVarUhLong();
            if (cancelerId < 0 || cancelerId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on cancelerId = " + cancelerId + ", it doesn't respect the following condition : cancelerId < 0 || cancelerId > 9.007199254740992E15");
            guestId = reader.ReadVarUhLong();
            if (guestId < 0 || guestId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on guestId = " + guestId + ", it doesn't respect the following condition : guestId < 0 || guestId > 9.007199254740992E15");
            

}


}


}