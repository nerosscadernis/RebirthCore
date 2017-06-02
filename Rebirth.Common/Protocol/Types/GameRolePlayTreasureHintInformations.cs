


















// Generated on 01/12/2017 03:53:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameRolePlayTreasureHintInformations : GameRolePlayActorInformations
{

public const short Id = 471;
public override short TypeId
{
    get { return Id; }
}

public uint npcId;
        

public GameRolePlayTreasureHintInformations()
{
}

public GameRolePlayTreasureHintInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, uint npcId)
         : base(contextualId, look, disposition)
        {
            this.npcId = npcId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)npcId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            npcId = reader.ReadVarUhShort();
            if (npcId < 0)
                throw new System.Exception("Forbidden value on npcId = " + npcId + ", it doesn't respect the following condition : npcId < 0");
            

}


}


}