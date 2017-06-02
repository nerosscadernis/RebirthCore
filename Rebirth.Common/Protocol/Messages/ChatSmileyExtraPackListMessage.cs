


















// Generated on 01/12/2017 03:52:55
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ChatSmileyExtraPackListMessage : NetworkMessage
{

public const uint Id = 6596;
public uint MessageId
{
    get { return Id; }
}

public sbyte[] packIds;
        

public ChatSmileyExtraPackListMessage()
{
}

public ChatSmileyExtraPackListMessage(sbyte[] packIds)
        {
            this.packIds = packIds;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)packIds.Length);
            foreach (var entry in packIds)
            {
                 writer.WriteSByte(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            packIds = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 packIds[i] = reader.ReadSByte();
            }
            

}


}


}