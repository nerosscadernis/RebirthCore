


















// Generated on 01/12/2017 03:53:00
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class SpouseInformationsMessage : NetworkMessage
{

public const uint Id = 6356;
public uint MessageId
{
    get { return Id; }
}

public Types.FriendSpouseInformations spouse;
        

public SpouseInformationsMessage()
{
}

public SpouseInformationsMessage(Types.FriendSpouseInformations spouse)
        {
            this.spouse = spouse;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(spouse.TypeId);
            spouse.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

spouse = ProtocolTypeManager.GetInstance<Types.FriendSpouseInformations>(reader.ReadShort());
            spouse.Deserialize(reader);
            

}


}


}