


















// Generated on 01/12/2017 03:52:53
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class AllianceFactsErrorMessage : NetworkMessage
{

public const uint Id = 6423;
public uint MessageId
{
    get { return Id; }
}

public uint allianceId;
        

public AllianceFactsErrorMessage()
{
}

public AllianceFactsErrorMessage(uint allianceId)
        {
            this.allianceId = allianceId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)allianceId);
            

}

public void Deserialize(IDataReader reader)
{

allianceId = reader.ReadVarUhInt();
            if (allianceId < 0)
                throw new System.Exception("Forbidden value on allianceId = " + allianceId + ", it doesn't respect the following condition : allianceId < 0");
            

}


}


}