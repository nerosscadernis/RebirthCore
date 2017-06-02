


















// Generated on 01/12/2017 03:53:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class FightCommonInformations : NetworkType
{

public const short Id = 43;
public virtual short TypeId
{
    get { return Id; }
}

public int fightId;
        public sbyte fightType;
        public Types.FightTeamInformations[] fightTeams;
        public uint[] fightTeamsPositions;
        public Types.FightOptionsInformations[] fightTeamsOptions;
        

public FightCommonInformations()
{
}

public FightCommonInformations(int fightId, sbyte fightType, Types.FightTeamInformations[] fightTeams, uint[] fightTeamsPositions, Types.FightOptionsInformations[] fightTeamsOptions)
        {
            this.fightId = fightId;
            this.fightType = fightType;
            this.fightTeams = fightTeams;
            this.fightTeamsPositions = fightTeamsPositions;
            this.fightTeamsOptions = fightTeamsOptions;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(fightId);
            writer.WriteSByte(fightType);
            writer.WriteUShort((ushort)fightTeams.Length);
            foreach (var entry in fightTeams)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)fightTeamsPositions.Length);
            foreach (var entry in fightTeamsPositions)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteUShort((ushort)fightTeamsOptions.Length);
            foreach (var entry in fightTeamsOptions)
            {
                 entry.Serialize(writer);
            }
            

}

public virtual void Deserialize(IDataReader reader)
{

fightId = reader.ReadInt();
            fightType = reader.ReadSByte();
            if (fightType < 0)
                throw new System.Exception("Forbidden value on fightType = " + fightType + ", it doesn't respect the following condition : fightType < 0");
            var limit = reader.ReadUShort();
            fightTeams = new Types.FightTeamInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 fightTeams[i] = ProtocolTypeManager.GetInstance<Types.FightTeamInformations>(reader.ReadShort());
                 fightTeams[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            fightTeamsPositions = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 fightTeamsPositions[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            fightTeamsOptions = new Types.FightOptionsInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 fightTeamsOptions[i] = new Types.FightOptionsInformations();
                 fightTeamsOptions[i].Deserialize(reader);
            }
            

}


}


}