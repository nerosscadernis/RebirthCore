


















// Generated on 01/12/2017 03:52:58
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class PartyInvitationArenaRequestMessage : PartyInvitationRequestMessage
{

public const uint Id = 6283;
public uint MessageId
{
    get { return Id; }
}



public PartyInvitationArenaRequestMessage()
{
}

public PartyInvitationArenaRequestMessage(string name)
         : base(name)
        {
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}