


















// Generated on 01/12/2017 03:52:58
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class DungeonPartyFinderRoomContentMessage : NetworkMessage
{

public const uint Id = 6247;
public uint MessageId
{
    get { return Id; }
}

public uint dungeonId;
        public Types.DungeonPartyFinderPlayer[] players;
        

public DungeonPartyFinderRoomContentMessage()
{
}

public DungeonPartyFinderRoomContentMessage(uint dungeonId, Types.DungeonPartyFinderPlayer[] players)
        {
            this.dungeonId = dungeonId;
            this.players = players;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)dungeonId);
            writer.WriteUShort((ushort)players.Length);
            foreach (var entry in players)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

dungeonId = reader.ReadVarUhShort();
            if (dungeonId < 0)
                throw new System.Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            var limit = reader.ReadUShort();
            players = new Types.DungeonPartyFinderPlayer[limit];
            for (int i = 0; i < limit; i++)
            {
                 players[i] = new Types.DungeonPartyFinderPlayer();
                 players[i].Deserialize(reader);
            }
            

}


}


}