


















// Generated on 01/12/2017 03:53:05
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class PrismsListUpdateMessage : PrismsListMessage
{

public const uint Id = 6438;
public uint MessageId
{
    get { return Id; }
}



public PrismsListUpdateMessage()
{
}

public PrismsListUpdateMessage(Types.PrismSubareaEmptyInfo[] prisms)
         : base(prisms)
        {
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}