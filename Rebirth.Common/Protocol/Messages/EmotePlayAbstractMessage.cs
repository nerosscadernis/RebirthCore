


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class EmotePlayAbstractMessage : NetworkMessage
{

public const uint Id = 5690;
public uint MessageId
{
    get { return Id; }
}

public byte emoteId;
        public double emoteStartTime;
        

public EmotePlayAbstractMessage()
{
}

public EmotePlayAbstractMessage(byte emoteId, double emoteStartTime)
        {
            this.emoteId = emoteId;
            this.emoteStartTime = emoteStartTime;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteByte(emoteId);
            writer.WriteDouble(emoteStartTime);
            

}

public void Deserialize(IDataReader reader)
{

emoteId = reader.ReadByte();
            if (emoteId < 0 || emoteId > 255)
                throw new System.Exception("Forbidden value on emoteId = " + emoteId + ", it doesn't respect the following condition : emoteId < 0 || emoteId > 255");
            emoteStartTime = reader.ReadDouble();
            if (emoteStartTime < -9.007199254740992E15 || emoteStartTime > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on emoteStartTime = " + emoteStartTime + ", it doesn't respect the following condition : emoteStartTime < -9.007199254740992E15 || emoteStartTime > 9.007199254740992E15");
            

}


}


}