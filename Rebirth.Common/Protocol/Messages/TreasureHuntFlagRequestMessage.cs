


















// Generated on 01/12/2017 03:52:59
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class TreasureHuntFlagRequestMessage : NetworkMessage
{

public const uint Id = 6508;
public uint MessageId
{
    get { return Id; }
}

public sbyte questType;
        public sbyte index;
        

public TreasureHuntFlagRequestMessage()
{
}

public TreasureHuntFlagRequestMessage(sbyte questType, sbyte index)
        {
            this.questType = questType;
            this.index = index;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(questType);
            writer.WriteSByte(index);
            

}

public void Deserialize(IDataReader reader)
{

questType = reader.ReadSByte();
            if (questType < 0)
                throw new System.Exception("Forbidden value on questType = " + questType + ", it doesn't respect the following condition : questType < 0");
            index = reader.ReadSByte();
            if (index < 0)
                throw new System.Exception("Forbidden value on index = " + index + ", it doesn't respect the following condition : index < 0");
            

}


}


}