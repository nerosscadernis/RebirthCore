


















// Generated on 01/12/2017 03:53:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class FightAllianceTeamInformations : FightTeamInformations
{

public const short Id = 439;
public override short TypeId
{
    get { return Id; }
}

public sbyte relation;
        

public FightAllianceTeamInformations()
{
}

public FightAllianceTeamInformations(sbyte teamId, double leaderId, sbyte teamSide, sbyte teamTypeId, sbyte nbWaves, Types.FightTeamMemberInformations[] teamMembers, sbyte relation)
         : base(teamId, leaderId, teamSide, teamTypeId, nbWaves, teamMembers)
        {
            this.relation = relation;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(relation);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            relation = reader.ReadSByte();
            if (relation < 0)
                throw new System.Exception("Forbidden value on relation = " + relation + ", it doesn't respect the following condition : relation < 0");
            

}


}


}