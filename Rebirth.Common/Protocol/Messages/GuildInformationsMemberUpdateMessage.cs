


















// Generated on 01/12/2017 03:53:00
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildInformationsMemberUpdateMessage : NetworkMessage
{

public const uint Id = 5597;
public uint MessageId
{
    get { return Id; }
}

public Types.GuildMember member;
        

public GuildInformationsMemberUpdateMessage()
{
}

public GuildInformationsMemberUpdateMessage(Types.GuildMember member)
        {
            this.member = member;
        }
        

public void Serialize(IDataWriter writer)
{

member.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

member = new Types.GuildMember();
            member.Deserialize(reader);
            

}


}


}