


















// Generated on 01/12/2017 03:52:53
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionFightInvisibleDetectedMessage : AbstractGameActionMessage
{

public const uint Id = 6320;
public uint MessageId
{
    get { return Id; }
}

public double targetId;
        public short cellId;
        

public GameActionFightInvisibleDetectedMessage()
{
}

public GameActionFightInvisibleDetectedMessage(uint actionId, double sourceId, double targetId, short cellId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.cellId = cellId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteShort(cellId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadDouble();
            if (targetId < -9.007199254740992E15 || targetId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on targetId = " + targetId + ", it doesn't respect the following condition : targetId < -9.007199254740992E15 || targetId > 9.007199254740992E15");
            cellId = reader.ReadShort();
            if (cellId < -1 || cellId > 559)
                throw new System.Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < -1 || cellId > 559");
            

}


}


}