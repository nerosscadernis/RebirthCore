


















// Generated on 01/12/2017 03:52:59
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class TreasureHuntFlagRequestAnswerMessage : NetworkMessage
{

public const uint Id = 6507;
public uint MessageId
{
    get { return Id; }
}

public sbyte questType;
        public sbyte result;
        public sbyte index;
        

public TreasureHuntFlagRequestAnswerMessage()
{
}

public TreasureHuntFlagRequestAnswerMessage(sbyte questType, sbyte result, sbyte index)
        {
            this.questType = questType;
            this.result = result;
            this.index = index;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(questType);
            writer.WriteSByte(result);
            writer.WriteSByte(index);
            

}

public void Deserialize(IDataReader reader)
{

questType = reader.ReadSByte();
            if (questType < 0)
                throw new System.Exception("Forbidden value on questType = " + questType + ", it doesn't respect the following condition : questType < 0");
            result = reader.ReadSByte();
            if (result < 0)
                throw new System.Exception("Forbidden value on result = " + result + ", it doesn't respect the following condition : result < 0");
            index = reader.ReadSByte();
            if (index < 0)
                throw new System.Exception("Forbidden value on index = " + index + ", it doesn't respect the following condition : index < 0");
            

}


}


}