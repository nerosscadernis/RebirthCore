


















// Generated on 01/12/2017 03:52:59
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class PartyPledgeLoyaltyRequestMessage : AbstractPartyMessage
{

public const uint Id = 6269;
public uint MessageId
{
    get { return Id; }
}

public bool loyal;
        

public PartyPledgeLoyaltyRequestMessage()
{
}

public PartyPledgeLoyaltyRequestMessage(uint partyId, bool loyal)
         : base(partyId)
        {
            this.loyal = loyal;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(loyal);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            loyal = reader.ReadBoolean();
            

}


}


}