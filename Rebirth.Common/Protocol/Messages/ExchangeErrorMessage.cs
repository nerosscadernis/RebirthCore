


















// Generated on 01/12/2017 03:53:02
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeErrorMessage : NetworkMessage
{

public const uint Id = 5513;
public uint MessageId
{
    get { return Id; }
}

public sbyte errorType;
        

public ExchangeErrorMessage()
{
}

public ExchangeErrorMessage(sbyte errorType)
        {
            this.errorType = errorType;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(errorType);
            

}

public void Deserialize(IDataReader reader)
{

errorType = reader.ReadSByte();
            

}


}


}