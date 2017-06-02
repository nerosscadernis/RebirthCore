


















// Generated on 01/12/2017 03:53:03
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeObjectsRemovedMessage : ExchangeObjectMessage
{

public const uint Id = 6532;
public uint MessageId
{
    get { return Id; }
}

public uint[] objectUID;
        

public ExchangeObjectsRemovedMessage()
{
}

public ExchangeObjectsRemovedMessage(bool remote, uint[] objectUID)
         : base(remote)
        {
            this.objectUID = objectUID;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)objectUID.Length);
            foreach (var entry in objectUID)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            objectUID = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectUID[i] = reader.ReadVarUhInt();
            }
            

}


}


}