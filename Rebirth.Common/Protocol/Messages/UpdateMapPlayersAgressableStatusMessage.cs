


















// Generated on 01/12/2017 03:53:05
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class UpdateMapPlayersAgressableStatusMessage : NetworkMessage
{

public const uint Id = 6454;
public uint MessageId
{
    get { return Id; }
}

public double[] playerIds;
        public sbyte[] enable;
        

public UpdateMapPlayersAgressableStatusMessage()
{
}

public UpdateMapPlayersAgressableStatusMessage(double[] playerIds, sbyte[] enable)
        {
            this.playerIds = playerIds;
            this.enable = enable;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)playerIds.Length);
            foreach (var entry in playerIds)
            {
                 writer.WriteVarLong(entry);
            }
            writer.WriteUShort((ushort)enable.Length);
            foreach (var entry in enable)
            {
                 writer.WriteSByte(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            playerIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 playerIds[i] = reader.ReadVarUhLong();
            }
            limit = reader.ReadUShort();
            enable = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 enable[i] = reader.ReadSByte();
            }
            

}


}


}