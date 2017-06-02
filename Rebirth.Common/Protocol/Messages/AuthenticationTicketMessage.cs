


















// Generated on 01/12/2017 03:52:54
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class AuthenticationTicketMessage : NetworkMessage
{

public const uint Id = 110;
public uint MessageId
{
    get { return Id; }
}

public string lang;
        public string ticket;
        

public AuthenticationTicketMessage()
{
}

public AuthenticationTicketMessage(string lang, string ticket)
        {
            this.lang = lang;
            this.ticket = ticket;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(lang);
            writer.WriteUTF(ticket);
            

}

public void Deserialize(IDataReader reader)
{

lang = reader.ReadUTF();
            ticket = reader.ReadUTF();
            

}


}


}