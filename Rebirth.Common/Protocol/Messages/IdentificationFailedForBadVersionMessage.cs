


















// Generated on 01/12/2017 03:52:52
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class IdentificationFailedForBadVersionMessage : IdentificationFailedMessage
{

public const uint Id = 21;
public uint MessageId
{
    get { return Id; }
}

public Types.Version requiredVersion;
        

public IdentificationFailedForBadVersionMessage()
{
}

public IdentificationFailedForBadVersionMessage(sbyte reason, Types.Version requiredVersion)
         : base(reason)
        {
            this.requiredVersion = requiredVersion;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            requiredVersion.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            requiredVersion = new Types.Version();
            requiredVersion.Deserialize(reader);
            

}


}


}