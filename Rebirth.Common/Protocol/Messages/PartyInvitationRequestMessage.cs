


















// Generated on 01/12/2017 03:52:59
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class PartyInvitationRequestMessage : NetworkMessage
{

public const uint Id = 5585;
public uint MessageId
{
    get { return Id; }
}

public string name;
        

public PartyInvitationRequestMessage()
{
}

public PartyInvitationRequestMessage(string name)
        {
            this.name = name;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(name);
            

}

public void Deserialize(IDataReader reader)
{

name = reader.ReadUTF();
            

}


}


}