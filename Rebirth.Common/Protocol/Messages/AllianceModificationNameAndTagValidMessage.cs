


















// Generated on 01/12/2017 03:52:53
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class AllianceModificationNameAndTagValidMessage : NetworkMessage
{

public const uint Id = 6449;
public uint MessageId
{
    get { return Id; }
}

public string allianceName;
        public string allianceTag;
        

public AllianceModificationNameAndTagValidMessage()
{
}

public AllianceModificationNameAndTagValidMessage(string allianceName, string allianceTag)
        {
            this.allianceName = allianceName;
            this.allianceTag = allianceTag;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(allianceName);
            writer.WriteUTF(allianceTag);
            

}

public void Deserialize(IDataReader reader)
{

allianceName = reader.ReadUTF();
            allianceTag = reader.ReadUTF();
            

}


}


}