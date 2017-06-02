


















// Generated on 01/12/2017 03:53:03
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class LivingObjectDissociateMessage : NetworkMessage
{

public const uint Id = 5723;
public uint MessageId
{
    get { return Id; }
}

public uint livingUID;
        public byte livingPosition;
        

public LivingObjectDissociateMessage()
{
}

public LivingObjectDissociateMessage(uint livingUID, byte livingPosition)
        {
            this.livingUID = livingUID;
            this.livingPosition = livingPosition;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)livingUID);
            writer.WriteByte(livingPosition);
            

}

public void Deserialize(IDataReader reader)
{

livingUID = reader.ReadVarUhInt();
            if (livingUID < 0)
                throw new System.Exception("Forbidden value on livingUID = " + livingUID + ", it doesn't respect the following condition : livingUID < 0");
            livingPosition = reader.ReadByte();
            if (livingPosition < 0 || livingPosition > 255)
                throw new System.Exception("Forbidden value on livingPosition = " + livingPosition + ", it doesn't respect the following condition : livingPosition < 0 || livingPosition > 255");
            

}


}


}