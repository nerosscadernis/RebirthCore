


















// Generated on 01/12/2017 03:52:59
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class TreasureHuntDigRequestAnswerFailedMessage : TreasureHuntDigRequestAnswerMessage
{

public const uint Id = 6509;
public uint MessageId
{
    get { return Id; }
}

public sbyte wrongFlagCount;
        

public TreasureHuntDigRequestAnswerFailedMessage()
{
}

public TreasureHuntDigRequestAnswerFailedMessage(sbyte questType, sbyte result, sbyte wrongFlagCount)
         : base(questType, result)
        {
            this.wrongFlagCount = wrongFlagCount;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(wrongFlagCount);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            wrongFlagCount = reader.ReadSByte();
            if (wrongFlagCount < 0)
                throw new System.Exception("Forbidden value on wrongFlagCount = " + wrongFlagCount + ", it doesn't respect the following condition : wrongFlagCount < 0");
            

}


}


}