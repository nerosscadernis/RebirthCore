


















// Generated on 01/12/2017 03:53:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class StatisticDataByte : StatisticData
{

public const short Id = 486;
public override short TypeId
{
    get { return Id; }
}

public sbyte value;
        

public StatisticDataByte()
{
}

public StatisticDataByte(sbyte value)
        {
            this.value = value;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(value);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadSByte();
            

}


}


}