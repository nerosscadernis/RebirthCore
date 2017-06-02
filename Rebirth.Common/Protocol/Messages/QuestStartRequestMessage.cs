


















// Generated on 01/12/2017 03:52:59
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class QuestStartRequestMessage : NetworkMessage
{

public const uint Id = 5643;
public uint MessageId
{
    get { return Id; }
}

public uint questId;
        

public QuestStartRequestMessage()
{
}

public QuestStartRequestMessage(uint questId)
        {
            this.questId = questId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)questId);
            

}

public void Deserialize(IDataReader reader)
{

questId = reader.ReadVarUhShort();
            if (questId < 0)
                throw new System.Exception("Forbidden value on questId = " + questId + ", it doesn't respect the following condition : questId < 0");
            

}


}


}