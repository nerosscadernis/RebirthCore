


















// Generated on 01/12/2017 03:52:56
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameDataPaddockObjectAddMessage : NetworkMessage
{

public const uint Id = 5990;
public uint MessageId
{
    get { return Id; }
}

public Types.PaddockItem paddockItemDescription;
        

public GameDataPaddockObjectAddMessage()
{
}

public GameDataPaddockObjectAddMessage(Types.PaddockItem paddockItemDescription)
        {
            this.paddockItemDescription = paddockItemDescription;
        }
        

public void Serialize(IDataWriter writer)
{

paddockItemDescription.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

paddockItemDescription = new Types.PaddockItem();
            paddockItemDescription.Deserialize(reader);
            

}


}


}