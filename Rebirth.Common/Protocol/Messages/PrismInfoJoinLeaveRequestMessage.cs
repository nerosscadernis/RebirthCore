


















// Generated on 01/12/2017 03:53:04
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class PrismInfoJoinLeaveRequestMessage : NetworkMessage
{

public const uint Id = 5844;
public uint MessageId
{
    get { return Id; }
}

public bool join;
        

public PrismInfoJoinLeaveRequestMessage()
{
}

public PrismInfoJoinLeaveRequestMessage(bool join)
        {
            this.join = join;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(join);
            

}

public void Deserialize(IDataReader reader)
{

join = reader.ReadBoolean();
            

}


}


}