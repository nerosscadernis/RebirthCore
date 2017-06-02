


















// Generated on 01/12/2017 03:53:03
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeWaitingResultMessage : NetworkMessage
{

public const uint Id = 5786;
public uint MessageId
{
    get { return Id; }
}

public bool bwait;
        

public ExchangeWaitingResultMessage()
{
}

public ExchangeWaitingResultMessage(bool bwait)
        {
            this.bwait = bwait;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(bwait);
            

}

public void Deserialize(IDataReader reader)
{

bwait = reader.ReadBoolean();
            

}


}


}