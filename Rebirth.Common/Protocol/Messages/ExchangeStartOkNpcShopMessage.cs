


















// Generated on 01/12/2017 03:53:03
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeStartOkNpcShopMessage : NetworkMessage
{

public const uint Id = 5761;
public uint MessageId
{
    get { return Id; }
}

public double npcSellerId;
        public uint tokenId;
        public Types.ObjectItemToSellInNpcShop[] objectsInfos;
        

public ExchangeStartOkNpcShopMessage()
{
}

public ExchangeStartOkNpcShopMessage(double npcSellerId, uint tokenId, Types.ObjectItemToSellInNpcShop[] objectsInfos)
        {
            this.npcSellerId = npcSellerId;
            this.tokenId = tokenId;
            this.objectsInfos = objectsInfos;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(npcSellerId);
            writer.WriteVarShort((int)tokenId);
            writer.WriteUShort((ushort)objectsInfos.Length);
            foreach (var entry in objectsInfos)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

npcSellerId = reader.ReadDouble();
            if (npcSellerId < -9.007199254740992E15 || npcSellerId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on npcSellerId = " + npcSellerId + ", it doesn't respect the following condition : npcSellerId < -9.007199254740992E15 || npcSellerId > 9.007199254740992E15");
            tokenId = reader.ReadVarUhShort();
            if (tokenId < 0)
                throw new System.Exception("Forbidden value on tokenId = " + tokenId + ", it doesn't respect the following condition : tokenId < 0");
            var limit = reader.ReadUShort();
            objectsInfos = new Types.ObjectItemToSellInNpcShop[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectsInfos[i] = new Types.ObjectItemToSellInNpcShop();
                 objectsInfos[i].Deserialize(reader);
            }
            

}


}


}