


















// Generated on 01/12/2017 03:52:53
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class AllianceListMessage : NetworkMessage
{

public const uint Id = 6408;
public uint MessageId
{
    get { return Id; }
}

public Types.AllianceFactSheetInformations[] alliances;
        

public AllianceListMessage()
{
}

public AllianceListMessage(Types.AllianceFactSheetInformations[] alliances)
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
            alliances = new Types.AllianceFactSheetInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 alliances[i] = new Types.AllianceFactSheetInformations();
                 alliances[i].Deserialize(reader);
            }
            

}


}


}