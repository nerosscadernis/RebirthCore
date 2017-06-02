


















// Generated on 01/12/2017 03:53:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class QuestObjectiveInformationsWithCompletion : QuestObjectiveInformations
{

public const short Id = 386;
public override short TypeId
{
    get { return Id; }
}

public uint curCompletion;
        public uint maxCompletion;
        

public QuestObjectiveInformationsWithCompletion()
{
}

public QuestObjectiveInformationsWithCompletion(uint objectiveId, bool objectiveStatus, string[] dialogParams, uint curCompletion, uint maxCompletion)
         : base(objectiveId, objectiveStatus, dialogParams)
        {
            this.curCompletion = curCompletion;
            this.maxCompletion = maxCompletion;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)curCompletion);
            writer.WriteVarShort((int)maxCompletion);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            curCompletion = reader.ReadVarUhShort();
            if (curCompletion < 0)
                throw new System.Exception("Forbidden value on curCompletion = " + curCompletion + ", it doesn't respect the following condition : curCompletion < 0");
            maxCompletion = reader.ReadVarUhShort();
            if (maxCompletion < 0)
                throw new System.Exception("Forbidden value on maxCompletion = " + maxCompletion + ", it doesn't respect the following condition : maxCompletion < 0");
            

}


}


}