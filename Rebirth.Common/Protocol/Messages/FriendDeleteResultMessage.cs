


















// Generated on 01/12/2017 03:53:00
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class FriendDeleteResultMessage : NetworkMessage
{

public const uint Id = 5601;
public uint MessageId
{
    get { return Id; }
}

public bool success;
        public string name;
        

public FriendDeleteResultMessage()
{
}

public FriendDeleteResultMessage(bool success, string name)
        {
            this.success = success;
            this.name = name;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(success);
            writer.WriteUTF(name);
            

}

public void Deserialize(IDataReader reader)
{

success = reader.ReadBoolean();
            name = reader.ReadUTF();
            

}


}


}