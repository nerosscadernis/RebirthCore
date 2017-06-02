


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class KickHavenBagRequestMessage : NetworkMessage
{

public const uint Id = 6652;
public uint MessageId
{
    get { return Id; }
}

public double guestId;
        

public KickHavenBagRequestMessage()
{
}

public KickHavenBagRequestMessage(double guestId)
        {
            this.guestId = guestId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(guestId);
            

}

public void Deserialize(IDataReader reader)
{

guestId = reader.ReadVarUhLong();
            if (guestId < 0 || guestId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on guestId = " + guestId + ", it doesn't respect the following condition : guestId < 0 || guestId > 9.007199254740992E15");
            

}


}


}