


















// Generated on 01/12/2017 03:52:59
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class QuestStepValidatedMessage : NetworkMessage
{

public const uint Id = 6099;
public uint MessageId
{
    get { return Id; }
}

public uint questId;
        public uint stepId;
        

public QuestStepValidatedMessage()
{
}

public QuestStepValidatedMessage(uint questId, uint stepId)
        {
            this.questId = questId;
            this.stepId = stepId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)questId);
            writer.WriteVarShort((int)stepId);
            

}

public void Deserialize(IDataReader reader)
{

questId = reader.ReadVarUhShort();
            if (questId < 0)
                throw new System.Exception("Forbidden value on questId = " + questId + ", it doesn't respect the following condition : questId < 0");
            stepId = reader.ReadVarUhShort();
            if (stepId < 0)
                throw new System.Exception("Forbidden value on stepId = " + stepId + ", it doesn't respect the following condition : stepId < 0");
            

}


}


}