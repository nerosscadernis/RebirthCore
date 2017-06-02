


















// Generated on 01/12/2017 03:52:52
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class IdentificationFailedBannedMessage : IdentificationFailedMessage
{

public const uint Id = 6174;
public uint MessageId
{
    get { return Id; }
}

public double banEndDate;
        

public IdentificationFailedBannedMessage()
{
}

public IdentificationFailedBannedMessage(sbyte reason, double banEndDate)
         : base(reason)
        {
            this.banEndDate = banEndDate;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(banEndDate);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            banEndDate = reader.ReadDouble();
            if (banEndDate < 0 || banEndDate > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on banEndDate = " + banEndDate + ", it doesn't respect the following condition : banEndDate < 0 || banEndDate > 9.007199254740992E15");
            

}


}


}