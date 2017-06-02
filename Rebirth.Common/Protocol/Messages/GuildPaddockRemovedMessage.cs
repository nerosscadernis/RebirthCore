


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildPaddockRemovedMessage : NetworkMessage
{

public const uint Id = 5955;
public uint MessageId
{
    get { return Id; }
}

public int paddockId;
        

public GuildPaddockRemovedMessage()
{
}

public GuildPaddockRemovedMessage(int paddockId)
        {
            this.paddockId = paddockId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(paddockId);
            

}

public void Deserialize(IDataReader reader)
{

paddockId = reader.ReadInt();
            

}


}


}