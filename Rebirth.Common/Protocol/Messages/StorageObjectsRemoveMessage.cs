


















// Generated on 01/12/2017 03:53:04
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class StorageObjectsRemoveMessage : NetworkMessage
{

public const uint Id = 6035;
public uint MessageId
{
    get { return Id; }
}

public uint[] objectUIDList;
        

public StorageObjectsRemoveMessage()
{
}

public StorageObjectsRemoveMessage(uint[] objectUIDList)
        {
            this.objectUIDList = objectUIDList;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)objectUIDList.Length);
            foreach (var entry in objectUIDList)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            objectUIDList = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectUIDList[i] = reader.ReadVarUhInt();
            }
            

}


}


}