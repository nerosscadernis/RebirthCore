


















// Generated on 01/12/2017 03:52:54
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class PlayerStatusUpdateErrorMessage : NetworkMessage
{

public const uint Id = 6385;
public uint MessageId
{
    get { return Id; }
}



public PlayerStatusUpdateErrorMessage()
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