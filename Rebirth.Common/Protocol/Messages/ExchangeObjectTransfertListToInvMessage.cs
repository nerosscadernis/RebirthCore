


















// Generated on 01/12/2017 03:53:02
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeObjectTransfertListToInvMessage : NetworkMessage
{

public const uint Id = 6039;
public uint MessageId
{
    get { return Id; }
}

public uint[] ids;
        

public ExchangeObjectTransfertListToInvMessage()
{
}

public ExchangeObjectTransfertListToInvMessage(uint[] ids)
        {
            this.ids = ids;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)ids.Length);
            foreach (var entry in ids)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            ids = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 ids[i] = reader.ReadVarUhInt();
            }
            

}


}


}