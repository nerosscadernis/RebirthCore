


















// Generated on 01/12/2017 03:52:54
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class BasicAckMessage : NetworkMessage
{

public const uint Id = 6362;
public uint MessageId
{
    get { return Id; }
}

public uint seq;
        public uint lastPacketId;
        

public BasicAckMessage()
{
}

public BasicAckMessage(uint seq, uint lastPacketId)
        {
            this.seq = seq;
            this.lastPacketId = lastPacketId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)seq);
            writer.WriteVarShort((int)lastPacketId);
            

}

public void Deserialize(IDataReader reader)
{

seq = reader.ReadVarUhInt();
            if (seq < 0)
                throw new System.Exception("Forbidden value on seq = " + seq + ", it doesn't respect the following condition : seq < 0");
            lastPacketId = reader.ReadVarUhShort();
            if (lastPacketId < 0)
                throw new System.Exception("Forbidden value on lastPacketId = " + lastPacketId + ", it doesn't respect the following condition : lastPacketId < 0");
            

}


}


}