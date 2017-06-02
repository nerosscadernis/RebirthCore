


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildFightPlayersEnemiesListMessage : NetworkMessage
{

public const uint Id = 5928;
public uint MessageId
{
    get { return Id; }
}

public int fightId;
        public Types.CharacterMinimalPlusLookInformations[] playerInfo;
        

public GuildFightPlayersEnemiesListMessage()
{
}

public GuildFightPlayersEnemiesListMessage(int fightId, Types.CharacterMinimalPlusLookInformations[] playerInfo)
        {
            this.fightId = fightId;
            this.playerInfo = playerInfo;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(fightId);
            writer.WriteUShort((ushort)playerInfo.Length);
            foreach (var entry in playerInfo)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

fightId = reader.ReadInt();
            if (fightId < 0)
                throw new System.Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            var limit = reader.ReadUShort();
            playerInfo = new Types.CharacterMinimalPlusLookInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 playerInfo[i] = new Types.CharacterMinimalPlusLookInformations();
                 playerInfo[i].Deserialize(reader);
            }
            

}


}


}