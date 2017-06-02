


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class HouseSellFromInsideRequestMessage : HouseSellRequestMessage
{

public const uint Id = 5884;
public uint MessageId
{
    get { return Id; }
}



public HouseSellFromInsideRequestMessage()
{
}

public HouseSellFromInsideRequestMessage(uint amount, bool forSale)
         : base(amount, forSale)
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