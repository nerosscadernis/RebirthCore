


















// Generated on 01/12/2017 03:52:59
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class PartyNewGuestMessage : AbstractPartyEventMessage
{

public const uint Id = 6260;
public uint MessageId
{
    get { return Id; }
}

public Types.PartyGuestInformations guest;
        

public PartyNewGuestMessage()
{
}

public PartyNewGuestMessage(uint partyId, Types.PartyGuestInformations guest)
         : base(partyId)
        {
            this.guest = guest;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            guest.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            guest = new Types.PartyGuestInformations();
            guest.Deserialize(reader);
            

}


}


}