


















// Generated on 01/12/2017 03:53:00
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GuestModeMessage : NetworkMessage
{

public const uint Id = 6505;
public uint MessageId
{
    get { return Id; }
}

public bool active;
        

public GuestModeMessage()
{
}

public GuestModeMessage(bool active)
        {
            this.active = active;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(active);
            

}

public void Deserialize(IDataReader reader)
{

active = reader.ReadBoolean();
            

}


}


}