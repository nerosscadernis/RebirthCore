


















// Generated on 01/12/2017 03:53:00
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class IgnoredListMessage : NetworkMessage
{

public const uint Id = 5674;
public uint MessageId
{
    get { return Id; }
}

public Types.IgnoredInformations[] ignoredList;
        

public IgnoredListMessage()
{
}

public IgnoredListMessage(Types.IgnoredInformations[] ignoredList)
        {
            this.ignoredList = ignoredList;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)ignoredList.Length);
            foreach (var entry in ignoredList)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            ignoredList = new Types.IgnoredInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 ignoredList[i] = ProtocolTypeManager.GetInstance<Types.IgnoredInformations>(reader.ReadShort());
                 ignoredList[i].Deserialize(reader);
            }
            

}


}


}