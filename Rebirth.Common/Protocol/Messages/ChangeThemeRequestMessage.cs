


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ChangeThemeRequestMessage : NetworkMessage
{

public const uint Id = 6639;
public uint MessageId
{
    get { return Id; }
}

public sbyte theme;
        

public ChangeThemeRequestMessage()
{
}

public ChangeThemeRequestMessage(sbyte theme)
        {
            this.theme = theme;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(theme);
            

}

public void Deserialize(IDataReader reader)
{

theme = reader.ReadSByte();
            

}


}


}