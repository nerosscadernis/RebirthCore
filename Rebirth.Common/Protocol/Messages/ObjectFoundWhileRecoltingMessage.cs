


















// Generated on 01/12/2017 03:53:04
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectFoundWhileRecoltingMessage : NetworkMessage
{

public const uint Id = 6017;
public uint MessageId
{
    get { return Id; }
}

public uint genericId;
        public uint quantity;
        public uint resourceGenericId;
        

public ObjectFoundWhileRecoltingMessage()
{
}

public ObjectFoundWhileRecoltingMessage(uint genericId, uint quantity, uint resourceGenericId)
        {
            this.genericId = genericId;
            this.quantity = quantity;
            this.resourceGenericId = resourceGenericId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)genericId);
            writer.WriteVarInt((int)quantity);
            writer.WriteVarInt((int)resourceGenericId);
            

}

public void Deserialize(IDataReader reader)
{

genericId = reader.ReadVarUhShort();
            if (genericId < 0)
                throw new System.Exception("Forbidden value on genericId = " + genericId + ", it doesn't respect the following condition : genericId < 0");
            quantity = reader.ReadVarUhInt();
            if (quantity < 0)
                throw new System.Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            resourceGenericId = reader.ReadVarUhInt();
            if (resourceGenericId < 0)
                throw new System.Exception("Forbidden value on resourceGenericId = " + resourceGenericId + ", it doesn't respect the following condition : resourceGenericId < 0");
            

}


}


}