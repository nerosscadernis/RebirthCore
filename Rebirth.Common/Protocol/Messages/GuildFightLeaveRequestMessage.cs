


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildFightLeaveRequestMessage : NetworkMessage
{

public const uint Id = 5715;
public uint MessageId
{
    get { return Id; }
}

public int taxCollectorId;
        public double characterId;
        

public GuildFightLeaveRequestMessage()
{
}

public GuildFightLeaveRequestMessage(int taxCollectorId, double characterId)
        {
            this.taxCollectorId = taxCollectorId;
            this.characterId = characterId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(taxCollectorId);
            writer.WriteVarLong(characterId);
            

}

public void Deserialize(IDataReader reader)
{

taxCollectorId = reader.ReadInt();
            if (taxCollectorId < 0)
                throw new System.Exception("Forbidden value on taxCollectorId = " + taxCollectorId + ", it doesn't respect the following condition : taxCollectorId < 0");
            characterId = reader.ReadVarUhLong();
            if (characterId < 0 || characterId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on characterId = " + characterId + ", it doesn't respect the following condition : characterId < 0 || characterId > 9.007199254740992E15");
            

}


}


}