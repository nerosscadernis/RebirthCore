


















// Generated on 01/12/2017 03:53:04
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectDeleteMessage : NetworkMessage
{

public const uint Id = 3022;
public uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        public uint quantity;
        

public ObjectDeleteMessage()
{
}

public ObjectDeleteMessage(uint objectUID, uint quantity)
        {
            this.objectUID = objectUID;
            this.quantity = quantity;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectUID);
            writer.WriteVarInt((int)quantity);
            

}

public void Deserialize(IDataReader reader)
{

objectUID = reader.ReadVarUhInt();
            if (objectUID < 0)
                throw new System.Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            quantity = reader.ReadVarUhInt();
            if (quantity < 0)
                throw new System.Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            

}


}


}