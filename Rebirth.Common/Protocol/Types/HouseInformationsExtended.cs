


















// Generated on 01/12/2017 03:53:09
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class HouseInformationsExtended : HouseInformations
{

public const short Id = 112;
public override short TypeId
{
    get { return Id; }
}

public Types.GuildInformations guildInfo;
        

public HouseInformationsExtended()
{
}

public HouseInformationsExtended(bool isOnSale, bool isSaleLocked, uint houseId, int[] doorsOnMap, string ownerName, uint modelId, Types.GuildInformations guildInfo)
         : base(isOnSale, isSaleLocked, houseId, doorsOnMap, ownerName, modelId)
        {
            this.guildInfo = guildInfo;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            guildInfo.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            guildInfo = new Types.GuildInformations();
            guildInfo.Deserialize(reader);
            

}


}


}