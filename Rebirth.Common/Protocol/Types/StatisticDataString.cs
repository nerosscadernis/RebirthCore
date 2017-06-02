


















// Generated on 01/12/2017 03:53:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class StatisticDataString : StatisticData
{

public const short Id = 487;
public override short TypeId
{
    get { return Id; }
}

public string value;
        

public StatisticDataString()
{
}

public StatisticDataString(string value)
        {
            this.value = value;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(value);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadUTF();
            

}


}


}