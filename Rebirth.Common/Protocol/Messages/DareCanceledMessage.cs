


















// Generated on 01/12/2017 03:52:59
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class DareCanceledMessage : NetworkMessage
{

public const uint Id = 6679;
public uint MessageId
{
    get { return Id; }
}

public double dareId;
        

public DareCanceledMessage()
{
}

public DareCanceledMessage(double dareId)
        {
            this.dareId = dareId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(dareId);
            

}

public void Deserialize(IDataReader reader)
{

dareId = reader.ReadDouble();
            if (dareId < 0 || dareId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on dareId = " + dareId + ", it doesn't respect the following condition : dareId < 0 || dareId > 9.007199254740992E15");
            

}


}


}