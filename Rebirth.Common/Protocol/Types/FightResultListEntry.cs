


















// Generated on 01/12/2017 03:53:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class FightResultListEntry : NetworkType
{

public const short Id = 16;
public virtual short TypeId
{
    get { return Id; }
}

public uint outcome;
        public sbyte wave;
        public Types.FightLoot rewards;
        

public FightResultListEntry()
{
}

public FightResultListEntry(uint outcome, sbyte wave, Types.FightLoot rewards)
        {
            this.outcome = outcome;
            this.wave = wave;
            this.rewards = rewards;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)outcome);
            writer.WriteSByte(wave);
            rewards.Serialize(writer);
            

}

public virtual void Deserialize(IDataReader reader)
{

outcome = reader.ReadVarUhShort();
            if (outcome < 0)
                throw new System.Exception("Forbidden value on outcome = " + outcome + ", it doesn't respect the following condition : outcome < 0");
            wave = reader.ReadSByte();
            if (wave < 0)
                throw new System.Exception("Forbidden value on wave = " + wave + ", it doesn't respect the following condition : wave < 0");
            rewards = new Types.FightLoot();
            rewards.Deserialize(reader);
            

}


}


}