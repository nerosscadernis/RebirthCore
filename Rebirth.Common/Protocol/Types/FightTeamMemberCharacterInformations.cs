


















// Generated on 01/12/2017 03:53:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class FightTeamMemberCharacterInformations : FightTeamMemberInformations
{

public const short Id = 13;
public override short TypeId
{
    get { return Id; }
}

public string name;
        public byte level;
        

public FightTeamMemberCharacterInformations()
{
}

public FightTeamMemberCharacterInformations(double id, string name, byte level)
         : base(id)
        {
            this.name = name;
            this.level = level;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            writer.WriteByte(level);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            level = reader.ReadByte();
            if (level < 0 || level > 255)
                throw new System.Exception("Forbidden value on level = " + level + ", it doesn't respect the following condition : level < 0 || level > 255");
            

}


}


}