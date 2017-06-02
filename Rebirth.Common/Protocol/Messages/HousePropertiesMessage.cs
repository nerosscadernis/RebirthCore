


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class HousePropertiesMessage : NetworkMessage
{

public const uint Id = 5734;
public uint MessageId
{
    get { return Id; }
}

public Types.HouseInformations properties;
        

public HousePropertiesMessage()
{
}

public HousePropertiesMessage(Types.HouseInformations properties)
        {
            this.properties = properties;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(properties.TypeId);
            properties.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

properties = ProtocolTypeManager.GetInstance<Types.HouseInformations>(reader.ReadShort());
            properties.Deserialize(reader);
            

}


}


}