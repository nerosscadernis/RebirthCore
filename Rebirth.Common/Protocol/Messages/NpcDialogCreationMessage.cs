


















// Generated on 01/12/2017 03:52:58
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class NpcDialogCreationMessage : NetworkMessage
{

public const uint Id = 5618;
public uint MessageId
{
    get { return Id; }
}

public int mapId;
        public int npcId;
        

public NpcDialogCreationMessage()
{
}

public NpcDialogCreationMessage(int mapId, int npcId)
        {
            this.mapId = mapId;
            this.npcId = npcId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(mapId);
            writer.WriteInt(npcId);
            

}

public void Deserialize(IDataReader reader)
{

mapId = reader.ReadInt();
            npcId = reader.ReadInt();
            

}


}


}