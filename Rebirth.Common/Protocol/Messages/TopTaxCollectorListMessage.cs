


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class TopTaxCollectorListMessage : AbstractTaxCollectorListMessage
{

public const uint Id = 6565;
public uint MessageId
{
    get { return Id; }
}

public bool isDungeon;
        

public TopTaxCollectorListMessage()
{
}

public TopTaxCollectorListMessage(Types.TaxCollectorInformations[] informations, bool isDungeon)
         : base(informations)
        {
            this.isDungeon = isDungeon;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(isDungeon);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            isDungeon = reader.ReadBoolean();
            

}


}


}