


















// Generated on 01/12/2017 03:53:02
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeObjectMessage : NetworkMessage
{

public const uint Id = 5515;
public uint MessageId
{
    get { return Id; }
}

public bool remote;
        

public ExchangeObjectMessage()
{
}

public ExchangeObjectMessage(bool remote)
        {
            this.remote = remote;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(remote);
            

}

public void Deserialize(IDataReader reader)
{

remote = reader.ReadBoolean();
            

}


}


}