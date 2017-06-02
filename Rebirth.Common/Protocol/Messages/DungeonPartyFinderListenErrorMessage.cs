


















// Generated on 01/12/2017 03:52:58
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class DungeonPartyFinderListenErrorMessage : NetworkMessage
{

public const uint Id = 6248;
public uint MessageId
{
    get { return Id; }
}

public uint dungeonId;
        

public DungeonPartyFinderListenErrorMessage()
{
}

public DungeonPartyFinderListenErrorMessage(uint dungeonId)
        {
            this.dungeonId = dungeonId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)dungeonId);
            

}

public void Deserialize(IDataReader reader)
{

dungeonId = reader.ReadVarUhShort();
            if (dungeonId < 0)
                throw new System.Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            

}


}


}