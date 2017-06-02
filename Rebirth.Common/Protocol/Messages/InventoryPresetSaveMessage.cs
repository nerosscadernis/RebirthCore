


















// Generated on 01/12/2017 03:53:04
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class InventoryPresetSaveMessage : NetworkMessage
{

public const uint Id = 6165;
public uint MessageId
{
    get { return Id; }
}

public sbyte presetId;
        public sbyte symbolId;
        public bool saveEquipment;
        

public InventoryPresetSaveMessage()
{
}

public InventoryPresetSaveMessage(sbyte presetId, sbyte symbolId, bool saveEquipment)
        {
            this.presetId = presetId;
            this.symbolId = symbolId;
            this.saveEquipment = saveEquipment;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(presetId);
            writer.WriteSByte(symbolId);
            writer.WriteBoolean(saveEquipment);
            

}

public void Deserialize(IDataReader reader)
{

presetId = reader.ReadSByte();
            if (presetId < 0)
                throw new System.Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
            symbolId = reader.ReadSByte();
            if (symbolId < 0)
                throw new System.Exception("Forbidden value on symbolId = " + symbolId + ", it doesn't respect the following condition : symbolId < 0");
            saveEquipment = reader.ReadBoolean();
            

}


}


}