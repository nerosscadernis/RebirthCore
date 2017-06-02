


















// Generated on 01/12/2017 03:53:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ClientYouAreDrunkMessage : DebugInClientMessage
{

public const uint Id = 6594;
public uint MessageId
{
    get { return Id; }
}



public ClientYouAreDrunkMessage()
{
}

public ClientYouAreDrunkMessage(sbyte level, string message)
         : base(level, message)
        {
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}