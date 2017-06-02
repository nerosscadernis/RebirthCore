


















// Generated on 01/12/2017 03:52:55
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameEntityDispositionMessage : NetworkMessage
{

public const uint Id = 5693;
public uint MessageId
{
    get { return Id; }
}

public Types.IdentifiedEntityDispositionInformations disposition;
        

public GameEntityDispositionMessage()
{
}

public GameEntityDispositionMessage(Types.IdentifiedEntityDispositionInformations disposition)
        {
            this.disposition = disposition;
        }
        

public void Serialize(IDataWriter writer)
{

disposition.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

disposition = new Types.IdentifiedEntityDispositionInformations();
            disposition.Deserialize(reader);
            

}


}


}