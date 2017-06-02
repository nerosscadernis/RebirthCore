


















// Generated on 01/12/2017 03:52:56
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class MountSetXpRatioRequestMessage : NetworkMessage
{

public const uint Id = 5989;
public uint MessageId
{
    get { return Id; }
}

public sbyte xpRatio;
        

public MountSetXpRatioRequestMessage()
{
}

public MountSetXpRatioRequestMessage(sbyte xpRatio)
        {
            this.xpRatio = xpRatio;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(xpRatio);
            

}

public void Deserialize(IDataReader reader)
{

xpRatio = reader.ReadSByte();
            if (xpRatio < 0)
                throw new System.Exception("Forbidden value on xpRatio = " + xpRatio + ", it doesn't respect the following condition : xpRatio < 0");
            

}


}


}