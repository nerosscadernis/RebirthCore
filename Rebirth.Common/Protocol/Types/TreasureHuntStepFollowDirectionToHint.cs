


















// Generated on 01/12/2017 03:53:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class TreasureHuntStepFollowDirectionToHint : TreasureHuntStep
{

public const short Id = 472;
public override short TypeId
{
    get { return Id; }
}

public sbyte direction;
        public uint npcId;
        

public TreasureHuntStepFollowDirectionToHint()
{
}

public TreasureHuntStepFollowDirectionToHint(sbyte direction, uint npcId)
        {
            this.direction = direction;
            this.npcId = npcId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(direction);
            writer.WriteVarShort((int)npcId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            direction = reader.ReadSByte();
            if (direction < 0)
                throw new System.Exception("Forbidden value on direction = " + direction + ", it doesn't respect the following condition : direction < 0");
            npcId = reader.ReadVarUhShort();
            if (npcId < 0)
                throw new System.Exception("Forbidden value on npcId = " + npcId + ", it doesn't respect the following condition : npcId < 0");
            

}


}


}