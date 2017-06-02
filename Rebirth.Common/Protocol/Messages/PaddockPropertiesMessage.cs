


















// Generated on 01/12/2017 03:52:58
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class PaddockPropertiesMessage : NetworkMessage
{

public const uint Id = 5824;
public uint MessageId
{
    get { return Id; }
}

public Types.PaddockInformations properties;
        

public PaddockPropertiesMessage()
{
}

public PaddockPropertiesMessage(Types.PaddockInformations properties)
        {
            this.properties = properties;
        }
        

public void Serialize(IDataWriter writer)
{

            //writer.WriteShort(properties.TypeId);
            properties.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

            properties = ProtocolTypeManager.GetInstance<Types.PaddockInformations>(reader.ReadShort());
            properties.Deserialize(reader);
            

}


}


}