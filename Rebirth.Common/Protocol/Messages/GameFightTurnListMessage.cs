


















// Generated on 01/12/2017 03:52:56
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightTurnListMessage : NetworkMessage
{

public const uint Id = 713;
public uint MessageId
{
    get { return Id; }
}

public double[] ids;
        public double[] deadsIds;
        

public GameFightTurnListMessage()
{
}

public GameFightTurnListMessage(double[] ids, double[] deadsIds)
        {
            this.ids = ids;
            this.deadsIds = deadsIds;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)ids.Length);
            foreach (var entry in ids)
            {
                 writer.WriteDouble(entry);
            }
            writer.WriteUShort((ushort)deadsIds.Length);
            foreach (var entry in deadsIds)
            {
                 writer.WriteDouble(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            ids = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 ids[i] = reader.ReadDouble();
            }
            limit = reader.ReadUShort();
            deadsIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 deadsIds[i] = reader.ReadDouble();
            }
            

}


}


}