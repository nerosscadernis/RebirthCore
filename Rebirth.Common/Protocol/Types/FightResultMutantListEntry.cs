


















// Generated on 01/12/2017 03:53:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class FightResultMutantListEntry : FightResultFighterListEntry
{

public const short Id = 216;
public override short TypeId
{
    get { return Id; }
}

public uint level;
        

public FightResultMutantListEntry()
{
}

public FightResultMutantListEntry(uint outcome, sbyte wave, Types.FightLoot rewards, double id, bool alive, uint level)
         : base(outcome, wave, rewards, id, alive)
        {
            this.level = level;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)level);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            level = reader.ReadVarUhShort();
            if (level < 0)
                throw new System.Exception("Forbidden value on level = " + level + ", it doesn't respect the following condition : level < 0");
            

}


}


}