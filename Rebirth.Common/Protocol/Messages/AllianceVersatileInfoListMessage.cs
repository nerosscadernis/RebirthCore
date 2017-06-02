


















// Generated on 01/12/2017 03:52:53
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class AllianceVersatileInfoListMessage : NetworkMessage
{

public const uint Id = 6436;
public uint MessageId
{
    get { return Id; }
}

public Types.AllianceVersatileInformations[] alliances;
        

public AllianceVersatileInfoListMessage()
{
}

public AllianceVersatileInfoListMessage(Types.AllianceVersatileInformations[] alliances)
        {
            this.alliances = alliances;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)alliances.Length);
            foreach (var entry in alliances)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            alliances = new Types.AllianceVersatileInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 alliances[i] = new Types.AllianceVersatileInformations();
                 alliances[i].Deserialize(reader);
            }
            

}


}


}