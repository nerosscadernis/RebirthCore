


















// Generated on 01/12/2017 03:52:52
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class BasicStatWithDataMessage : BasicStatMessage
{

public const uint Id = 6573;
public uint MessageId
{
    get { return Id; }
}

public Types.StatisticData[] datas;
        

public BasicStatWithDataMessage()
{
}

public BasicStatWithDataMessage(double timeSpent, uint statId, Types.StatisticData[] datas)
         : base(timeSpent, statId)
        {
            this.datas = datas;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)datas.Length);
            foreach (var entry in datas)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            datas = new Types.StatisticData[limit];
            for (int i = 0; i < limit; i++)
            {
                 datas[i] = ProtocolTypeManager.GetInstance<Types.StatisticData>(reader.ReadShort());
                 datas[i].Deserialize(reader);
            }
            

}


}


}