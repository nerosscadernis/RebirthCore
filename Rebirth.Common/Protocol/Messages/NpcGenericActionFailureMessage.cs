


















// Generated on 01/12/2017 03:52:58
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class NpcGenericActionFailureMessage : NetworkMessage
{

public const uint Id = 5900;
public uint MessageId
{
    get { return Id; }
}



public NpcGenericActionFailureMessage()
{
}



public void Serialize(IDataWriter writer)
{



}

public void Deserialize(IDataReader reader)
{



}


}


}