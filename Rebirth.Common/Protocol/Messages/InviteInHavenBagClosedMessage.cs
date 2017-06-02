


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class InviteInHavenBagClosedMessage : NetworkMessage
{

public const uint Id = 6645;
public uint MessageId
{
    get { return Id; }
}

public Types.CharacterMinimalInformations hostInformations;
        

public InviteInHavenBagClosedMessage()
{
}

public InviteInHavenBagClosedMessage(Types.CharacterMinimalInformations hostInformations)
        {
            this.hostInformations = hostInformations;
        }
        

public void Serialize(IDataWriter writer)
{

hostInformations.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

hostInformations = new Types.CharacterMinimalInformations();
            hostInformations.Deserialize(reader);
            

}


}


}