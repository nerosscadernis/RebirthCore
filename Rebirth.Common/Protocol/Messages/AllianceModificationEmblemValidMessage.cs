


















// Generated on 01/12/2017 03:52:53
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class AllianceModificationEmblemValidMessage : NetworkMessage
{

public const uint Id = 6447;
public uint MessageId
{
    get { return Id; }
}

public Types.GuildEmblem Alliancemblem;
        

public AllianceModificationEmblemValidMessage()
{
}

public AllianceModificationEmblemValidMessage(Types.GuildEmblem Alliancemblem)
        {
            this.Alliancemblem = Alliancemblem;
        }
        

public void Serialize(IDataWriter writer)
{

Alliancemblem.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

Alliancemblem = new Types.GuildEmblem();
            Alliancemblem.Deserialize(reader);
            

}


}


}