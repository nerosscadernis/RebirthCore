


















// Generated on 01/12/2017 03:53:04
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectFeedMessage : NetworkMessage
{

public const uint Id = 6290;
public uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        public uint foodUID;
        public uint foodQuantity;
        

public ObjectFeedMessage()
{
}

public ObjectFeedMessage(uint objectUID, uint foodUID, uint foodQuantity)
        {
            this.objectUID = objectUID;
            this.foodUID = foodUID;
            this.foodQuantity = foodQuantity;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectUID);
            writer.WriteVarInt((int)foodUID);
            writer.WriteVarInt((int)foodQuantity);
            

}

public void Deserialize(IDataReader reader)
{

objectUID = reader.ReadVarUhInt();
            if (objectUID < 0)
                throw new System.Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            foodUID = reader.ReadVarUhInt();
            if (foodUID < 0)
                throw new System.Exception("Forbidden value on foodUID = " + foodUID + ", it doesn't respect the following condition : foodUID < 0");
            foodQuantity = reader.ReadVarUhInt();
            if (foodQuantity < 0)
                throw new System.Exception("Forbidden value on foodQuantity = " + foodQuantity + ", it doesn't respect the following condition : foodQuantity < 0");
            

}


}


}