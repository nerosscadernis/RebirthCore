


















// Generated on 01/12/2017 03:53:03
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class MimicryObjectFeedAndAssociateRequestMessage : SymbioticObjectAssociateRequestMessage
{

public const uint Id = 6460;
public uint MessageId
{
    get { return Id; }
}

public uint foodUID;
        public byte foodPos;
        public bool preview;
        

public MimicryObjectFeedAndAssociateRequestMessage()
{
}

public MimicryObjectFeedAndAssociateRequestMessage(uint symbioteUID, byte symbiotePos, uint hostUID, byte hostPos, uint foodUID, byte foodPos, bool preview)
         : base(symbioteUID, symbiotePos, hostUID, hostPos)
        {
            this.foodUID = foodUID;
            this.foodPos = foodPos;
            this.preview = preview;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)foodUID);
            writer.WriteByte(foodPos);
            writer.WriteBoolean(preview);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            foodUID = reader.ReadVarUhInt();
            if (foodUID < 0)
                throw new System.Exception("Forbidden value on foodUID = " + foodUID + ", it doesn't respect the following condition : foodUID < 0");
            foodPos = reader.ReadByte();
            if (foodPos < 0 || foodPos > 255)
                throw new System.Exception("Forbidden value on foodPos = " + foodPos + ", it doesn't respect the following condition : foodPos < 0 || foodPos > 255");
            preview = reader.ReadBoolean();
            

}


}


}