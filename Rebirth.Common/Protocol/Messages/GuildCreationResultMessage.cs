


















// Generated on 01/12/2017 03:53:00
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildCreationResultMessage : NetworkMessage
{

public const uint Id = 5554;
public uint MessageId
{
    get { return Id; }
}

public sbyte result;
        

public GuildCreationResultMessage()
{
}

public GuildCreationResultMessage(sbyte result)
        {
            this.result = result;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(result);
            

}

public void Deserialize(IDataReader reader)
{

result = reader.ReadSByte();
            if (result < 0)
                throw new System.Exception("Forbidden value on result = " + result + ", it doesn't respect the following condition : result < 0");
            

}


}


}