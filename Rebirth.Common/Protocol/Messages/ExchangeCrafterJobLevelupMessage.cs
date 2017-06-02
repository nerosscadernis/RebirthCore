


















// Generated on 01/12/2017 03:53:02
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeCrafterJobLevelupMessage : NetworkMessage
{

public const uint Id = 6598;
public uint MessageId
{
    get { return Id; }
}

public byte crafterJobLevel;
        

public ExchangeCrafterJobLevelupMessage()
{
}

public ExchangeCrafterJobLevelupMessage(byte crafterJobLevel)
        {
            this.crafterJobLevel = crafterJobLevel;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteByte(crafterJobLevel);
            

}

public void Deserialize(IDataReader reader)
{

crafterJobLevel = reader.ReadByte();
            if (crafterJobLevel < 0 || crafterJobLevel > 255)
                throw new System.Exception("Forbidden value on crafterJobLevel = " + crafterJobLevel + ", it doesn't respect the following condition : crafterJobLevel < 0 || crafterJobLevel > 255");
            

}


}


}