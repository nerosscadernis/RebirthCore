


















// Generated on 01/12/2017 03:52:56
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class MountDataMessage : NetworkMessage
{

public const uint Id = 5973;
public uint MessageId
{
    get { return Id; }
}

public Types.MountClientData mountData;
        

public MountDataMessage()
{
}

public MountDataMessage(Types.MountClientData mountData)
        {
            this.mountData = mountData;
        }
        

public void Serialize(IDataWriter writer)
{

mountData.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

mountData = new Types.MountClientData();
            mountData.Deserialize(reader);
            

}


}


}