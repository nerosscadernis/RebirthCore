


















// Generated on 01/12/2017 03:53:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class HumanOptionGuild : HumanOption
{

public const short Id = 409;
public override short TypeId
{
    get { return Id; }
}

public Types.GuildInformations guildInformations;
        

public HumanOptionGuild()
{
}

public HumanOptionGuild(Types.GuildInformations guildInformations)
        {
            this.guildInformations = guildInformations;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            guildInformations.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            guildInformations = new Types.GuildInformations();
            guildInformations.Deserialize(reader);
            

}


}


}