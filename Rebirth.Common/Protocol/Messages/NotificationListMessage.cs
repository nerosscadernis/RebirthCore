


















// Generated on 01/12/2017 03:52:56
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class NotificationListMessage : NetworkMessage
{

public const uint Id = 6087;
public uint MessageId
{
    get { return Id; }
}

public int[] flags;
        

public NotificationListMessage()
{
}

public NotificationListMessage(int[] flags)
        {
            this.flags = flags;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)flags.Length);
            foreach (var entry in flags)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            flags = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 flags[i] = reader.ReadVarInt();
            }
            

}


}


}