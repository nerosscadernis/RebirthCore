


















// Generated on 01/12/2017 03:53:04
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class InventoryPresetUpdateMessage : NetworkMessage
{

public const uint Id = 6171;
public uint MessageId
{
    get { return Id; }
}

public Types.Preset preset;
        

public InventoryPresetUpdateMessage()
{
}

public InventoryPresetUpdateMessage(Types.Preset preset)
        {
            this.preset = preset;
        }
        

public void Serialize(IDataWriter writer)
{

preset.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

preset = new Types.Preset();
            preset.Deserialize(reader);
            

}


}


}