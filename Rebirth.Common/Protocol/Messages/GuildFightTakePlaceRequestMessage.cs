


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildFightTakePlaceRequestMessage : GuildFightJoinRequestMessage
{

public const uint Id = 6235;
public uint MessageId
{
    get { return Id; }
}

public int replacedCharacterId;
        

public GuildFightTakePlaceRequestMessage()
{
}

public GuildFightTakePlaceRequestMessage(int taxCollectorId, int replacedCharacterId)
         : base(taxCollectorId)
        {
            this.replacedCharacterId = replacedCharacterId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(replacedCharacterId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            replacedCharacterId = reader.ReadInt();
            

}


}


}