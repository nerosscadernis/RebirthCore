


















// Generated on 01/12/2017 03:52:56
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class MountXpRatioMessage : NetworkMessage
{

public const uint Id = 5970;
public uint MessageId
{
    get { return Id; }
}

public sbyte ratio;
        

public MountXpRatioMessage()
{
}

public MountXpRatioMessage(sbyte ratio)
        {
            this.ratio = ratio;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(ratio);
            

}

public void Deserialize(IDataReader reader)
{

ratio = reader.ReadSByte();
            if (ratio < 0)
                throw new System.Exception("Forbidden value on ratio = " + ratio + ", it doesn't respect the following condition : ratio < 0");
            

}


}


}