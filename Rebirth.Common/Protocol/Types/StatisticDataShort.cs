


















// Generated on 01/12/2017 03:53:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class StatisticDataShort : StatisticData
{

public const short Id = 488;
public override short TypeId
{
    get { return Id; }
}

public short value;
        

public StatisticDataShort()
{
}

public StatisticDataShort(short value)
        {
            this.value = value;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(value);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadShort();
            

}


}


}