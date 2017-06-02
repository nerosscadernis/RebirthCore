


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class EmotePlayErrorMessage : NetworkMessage
{

public const uint Id = 5688;
public uint MessageId
{
    get { return Id; }
}

public byte emoteId;
        

public EmotePlayErrorMessage()
{
}

public EmotePlayErrorMessage(byte emoteId)
        {
            this.emoteId = emoteId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteByte(emoteId);
            

}

public void Deserialize(IDataReader reader)
{

emoteId = reader.ReadByte();
            if (emoteId < 0 || emoteId > 255)
                throw new System.Exception("Forbidden value on emoteId = " + emoteId + ", it doesn't respect the following condition : emoteId < 0 || emoteId > 255");
            

}


}


}