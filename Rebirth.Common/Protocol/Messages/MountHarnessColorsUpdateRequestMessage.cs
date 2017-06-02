


















// Generated on 01/12/2017 03:52:56
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class MountHarnessColorsUpdateRequestMessage : NetworkMessage
{

public const uint Id = 6697;
public uint MessageId
{
    get { return Id; }
}

public bool useHarnessColors;
        

public MountHarnessColorsUpdateRequestMessage()
{
}

public MountHarnessColorsUpdateRequestMessage(bool useHarnessColors)
        {
            this.useHarnessColors = useHarnessColors;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(useHarnessColors);
            

}

public void Deserialize(IDataReader reader)
{

useHarnessColors = reader.ReadBoolean();
            

}


}


}