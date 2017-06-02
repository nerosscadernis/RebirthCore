


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildMemberOnlineStatusMessage : NetworkMessage
{

public const uint Id = 6061;
public uint MessageId
{
    get { return Id; }
}

public double memberId;
        public bool online;
        

public GuildMemberOnlineStatusMessage()
{
}

public GuildMemberOnlineStatusMessage(double memberId, bool online)
        {
            this.memberId = memberId;
            this.online = online;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(memberId);
            writer.WriteBoolean(online);
            

}

public void Deserialize(IDataReader reader)
{

memberId = reader.ReadVarUhLong();
            if (memberId < 0 || memberId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on memberId = " + memberId + ", it doesn't respect the following condition : memberId < 0 || memberId > 9.007199254740992E15");
            online = reader.ReadBoolean();
            

}


}


}