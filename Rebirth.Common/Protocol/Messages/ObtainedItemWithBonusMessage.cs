


















// Generated on 01/12/2017 03:53:04
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ObtainedItemWithBonusMessage : ObtainedItemMessage
{

public const uint Id = 6520;
public uint MessageId
{
    get { return Id; }
}

public uint bonusQuantity;
        

public ObtainedItemWithBonusMessage()
{
}

public ObtainedItemWithBonusMessage(uint genericId, uint baseQuantity, uint bonusQuantity)
         : base(genericId, baseQuantity)
        {
            this.bonusQuantity = bonusQuantity;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)bonusQuantity);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            bonusQuantity = reader.ReadVarUhInt();
            if (bonusQuantity < 0)
                throw new System.Exception("Forbidden value on bonusQuantity = " + bonusQuantity + ", it doesn't respect the following condition : bonusQuantity < 0");
            

}


}


}