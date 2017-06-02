


















// Generated on 01/12/2017 03:52:53
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class SequenceEndMessage : NetworkMessage
{

public const uint Id = 956;
public uint MessageId
{
    get { return Id; }
}

public uint actionId;
        public double authorId;
        public sbyte sequenceType;
        

public SequenceEndMessage()
{
}

public SequenceEndMessage(uint actionId, double authorId, sbyte sequenceType)
        {
            this.actionId = actionId;
            this.authorId = authorId;
            this.sequenceType = sequenceType;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)actionId);
            writer.WriteDouble(authorId);
            writer.WriteSByte(sequenceType);
            

}

public void Deserialize(IDataReader reader)
{

actionId = reader.ReadVarUhShort();
            if (actionId < 0)
                throw new System.Exception("Forbidden value on actionId = " + actionId + ", it doesn't respect the following condition : actionId < 0");
            authorId = reader.ReadDouble();
            if (authorId < -9.007199254740992E15 || authorId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on authorId = " + authorId + ", it doesn't respect the following condition : authorId < -9.007199254740992E15 || authorId > 9.007199254740992E15");
            sequenceType = reader.ReadSByte();
            

}


}


}