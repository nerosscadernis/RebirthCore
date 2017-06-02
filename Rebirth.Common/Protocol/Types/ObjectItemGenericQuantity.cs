


















// Generated on 01/12/2017 03:53:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ObjectItemGenericQuantity : Item
{

public const short Id = 483;
public override short TypeId
{
    get { return Id; }
}

public uint objectGID;
        public uint quantity;
        

public ObjectItemGenericQuantity()
{
}

public ObjectItemGenericQuantity(uint objectGID, uint quantity)
        {
            this.objectGID = objectGID;
            this.quantity = quantity;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)objectGID);
            writer.WriteVarInt((int)quantity);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            objectGID = reader.ReadVarUhShort();
            if (objectGID < 0)
                throw new System.Exception("Forbidden value on objectGID = " + objectGID + ", it doesn't respect the following condition : objectGID < 0");
            quantity = reader.ReadVarUhInt();
            if (quantity < 0)
                throw new System.Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            

}


}


}