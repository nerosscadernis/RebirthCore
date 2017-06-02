


















// Generated on 01/12/2017 03:53:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameRolePlayMutantInformations : GameRolePlayHumanoidInformations
{

public const short Id = 3;
public override short TypeId
{
    get { return Id; }
}

public uint monsterId;
        public sbyte powerLevel;
        

public GameRolePlayMutantInformations()
{
}

public GameRolePlayMutantInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, string name, Types.HumanInformations humanoidInfo, int accountId, uint monsterId, sbyte powerLevel)
         : base(contextualId, look, disposition, name, humanoidInfo, accountId)
        {
            this.monsterId = monsterId;
            this.powerLevel = powerLevel;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)monsterId);
            writer.WriteSByte(powerLevel);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            monsterId = reader.ReadVarUhShort();
            if (monsterId < 0)
                throw new System.Exception("Forbidden value on monsterId = " + monsterId + ", it doesn't respect the following condition : monsterId < 0");
            powerLevel = reader.ReadSByte();
            

}


}


}