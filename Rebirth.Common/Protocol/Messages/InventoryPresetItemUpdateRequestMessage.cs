


















// Generated on 01/12/2017 03:53:04
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class InventoryPresetItemUpdateRequestMessage : NetworkMessage
{

public const uint Id = 6210;
public uint MessageId
{
    get { return Id; }
}

public sbyte presetId;
        public byte position;
        public uint objUid;
        

public InventoryPresetItemUpdateRequestMessage()
{
}

public InventoryPresetItemUpdateRequestMessage(sbyte presetId, byte position, uint objUid)
        {
            this.presetId = presetId;
            this.position = position;
            this.objUid = objUid;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(presetId);
            writer.WriteByte(position);
            writer.WriteVarInt((int)objUid);
            

}

public void Deserialize(IDataReader reader)
{

presetId = reader.ReadSByte();
            if (presetId < 0)
                throw new System.Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
            position = reader.ReadByte();
            if (position < 0 || position > 255)
                throw new System.Exception("Forbidden value on position = " + position + ", it doesn't respect the following condition : position < 0 || position > 255");
            objUid = reader.ReadVarUhInt();
            if (objUid < 0)
                throw new System.Exception("Forbidden value on objUid = " + objUid + ", it doesn't respect the following condition : objUid < 0");
            

}


}


}