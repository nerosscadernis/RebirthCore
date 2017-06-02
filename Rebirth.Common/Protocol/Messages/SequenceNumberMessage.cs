


















// Generated on 01/12/2017 03:52:54
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class SequenceNumberMessage : NetworkMessage
{

public const uint Id = 6317;
public uint MessageId
{
    get { return Id; }
}

public ushort number;
        

public SequenceNumberMessage()
{
}

public SequenceNumberMessage(ushort number)
        {
            this.number = number;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort(number);
            

}

public void Deserialize(IDataReader reader)
{

number = reader.ReadUShort();
            if (number < 0 || number > 65535)
                throw new System.Exception("Forbidden value on number = " + number + ", it doesn't respect the following condition : number < 0 || number > 65535");
            

}


}


}