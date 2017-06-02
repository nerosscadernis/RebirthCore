


















// Generated on 01/12/2017 03:53:03
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class JobBookSubscribeRequestMessage : NetworkMessage
{

public const uint Id = 6592;
public uint MessageId
{
    get { return Id; }
}

public sbyte[] jobIds;
        

public JobBookSubscribeRequestMessage()
{
}

public JobBookSubscribeRequestMessage(sbyte[] jobIds)
        {
            this.jobIds = jobIds;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)jobIds.Length);
            foreach (var entry in jobIds)
            {
                 writer.WriteSByte(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            jobIds = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 jobIds[i] = reader.ReadSByte();
            }
            

}


}


}