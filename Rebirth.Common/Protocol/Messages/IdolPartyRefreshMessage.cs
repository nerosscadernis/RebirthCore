


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class IdolPartyRefreshMessage : NetworkMessage
{

public const uint Id = 6583;
public uint MessageId
{
    get { return Id; }
}

public Types.PartyIdol partyIdol;
        

public IdolPartyRefreshMessage()
{
}

public IdolPartyRefreshMessage(Types.PartyIdol partyIdol)
        {
            this.partyIdol = partyIdol;
        }
        

public void Serialize(IDataWriter writer)
{

partyIdol.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

partyIdol = new Types.PartyIdol();
            partyIdol.Deserialize(reader);
            

}


}


}