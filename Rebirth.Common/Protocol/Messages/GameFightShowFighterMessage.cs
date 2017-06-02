


















// Generated on 01/12/2017 03:52:56
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightShowFighterMessage : NetworkMessage
{

public const uint Id = 5864;
public uint MessageId
{
    get { return Id; }
}

public Types.GameFightFighterInformations informations;
        

public GameFightShowFighterMessage()
{
}

public GameFightShowFighterMessage(Types.GameFightFighterInformations informations)
        {
            this.informations = informations;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(informations.TypeId);
            informations.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

informations = ProtocolTypeManager.GetInstance<Types.GameFightFighterInformations>(reader.ReadShort());
            informations.Deserialize(reader);
            

}


}


}