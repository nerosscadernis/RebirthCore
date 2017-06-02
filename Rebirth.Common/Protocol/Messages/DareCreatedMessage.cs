


















// Generated on 01/12/2017 03:52:59
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class DareCreatedMessage : NetworkMessage
{

public const uint Id = 6668;
public uint MessageId
{
    get { return Id; }
}

public Types.DareInformations dareInfos;
        public bool needNotifications;
        

public DareCreatedMessage()
{
}

public DareCreatedMessage(Types.DareInformations dareInfos, bool needNotifications)
        {
            this.dareInfos = dareInfos;
            this.needNotifications = needNotifications;
        }
        

public void Serialize(IDataWriter writer)
{

dareInfos.Serialize(writer);
            writer.WriteBoolean(needNotifications);
            

}

public void Deserialize(IDataReader reader)
{

dareInfos = new Types.DareInformations();
            dareInfos.Deserialize(reader);
            needNotifications = reader.ReadBoolean();
            

}


}


}