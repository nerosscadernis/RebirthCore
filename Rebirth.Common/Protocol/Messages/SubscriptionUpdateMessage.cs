


















// Generated on 01/12/2017 03:53:05
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class SubscriptionUpdateMessage : NetworkMessage
{

public const uint Id = 6616;
public uint MessageId
{
    get { return Id; }
}

public double timestamp;
        

public SubscriptionUpdateMessage()
{
}

public SubscriptionUpdateMessage(double timestamp)
        {
            this.timestamp = timestamp;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(timestamp);
            

}

public void Deserialize(IDataReader reader)
{

timestamp = reader.ReadDouble();
            if (timestamp < -9.007199254740992E15 || timestamp > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on timestamp = " + timestamp + ", it doesn't respect the following condition : timestamp < -9.007199254740992E15 || timestamp > 9.007199254740992E15");
            

}


}


}