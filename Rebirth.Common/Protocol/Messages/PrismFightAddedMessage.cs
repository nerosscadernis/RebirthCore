


















// Generated on 01/12/2017 03:53:04
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class PrismFightAddedMessage : NetworkMessage
{

public const uint Id = 6452;
public uint MessageId
{
    get { return Id; }
}

public Types.PrismFightersInformation fight;
        

public PrismFightAddedMessage()
{
}

public PrismFightAddedMessage(Types.PrismFightersInformation fight)
        {
            this.fight = fight;
        }
        

public void Serialize(IDataWriter writer)
{

fight.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

fight = new Types.PrismFightersInformation();
            fight.Deserialize(reader);
            

}


}


}