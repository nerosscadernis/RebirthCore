


















// Generated on 01/12/2017 03:53:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ObjectItemGenericQuantityPrice : ObjectItemGenericQuantity
{

public const short Id = 494;
public override short TypeId
{
    get { return Id; }
}

public uint price;
        

public ObjectItemGenericQuantityPrice()
{
}

public ObjectItemGenericQuantityPrice(uint objectGID, uint quantity, uint price)
         : base(objectGID, quantity)
        {
            this.price = price;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)price);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            price = reader.ReadVarUhInt();
            if (price < 0)
                throw new System.Exception("Forbidden value on price = " + price + ", it doesn't respect the following condition : price < 0");
            

}


}


}