


















// Generated on 01/12/2017 03:53:10
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class AllianceVersatileInformations : NetworkType
{

public const short Id = 432;
public virtual short TypeId
{
    get { return Id; }
}

public uint allianceId;
        public uint nbGuilds;
        public uint nbMembers;
        public uint nbSubarea;
        

public AllianceVersatileInformations()
{
}

public AllianceVersatileInformations(uint allianceId, uint nbGuilds, uint nbMembers, uint nbSubarea)
        {
            this.allianceId = allianceId;
            this.nbGuilds = nbGuilds;
            this.nbMembers = nbMembers;
            this.nbSubarea = nbSubarea;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)allianceId);
            writer.WriteVarShort((int)nbGuilds);
            writer.WriteVarShort((int)nbMembers);
            writer.WriteVarShort((int)nbSubarea);
            

}

public virtual void Deserialize(IDataReader reader)
{

allianceId = reader.ReadVarUhInt();
            if (allianceId < 0)
                throw new System.Exception("Forbidden value on allianceId = " + allianceId + ", it doesn't respect the following condition : allianceId < 0");
            nbGuilds = reader.ReadVarUhShort();
            if (nbGuilds < 0)
                throw new System.Exception("Forbidden value on nbGuilds = " + nbGuilds + ", it doesn't respect the following condition : nbGuilds < 0");
            nbMembers = reader.ReadVarUhShort();
            if (nbMembers < 0)
                throw new System.Exception("Forbidden value on nbMembers = " + nbMembers + ", it doesn't respect the following condition : nbMembers < 0");
            nbSubarea = reader.ReadVarUhShort();
            if (nbSubarea < 0)
                throw new System.Exception("Forbidden value on nbSubarea = " + nbSubarea + ", it doesn't respect the following condition : nbSubarea < 0");
            

}


}


}