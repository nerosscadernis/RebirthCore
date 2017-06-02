


















// Generated on 01/12/2017 03:53:00
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class IgnoredAddRequestMessage : NetworkMessage
{

public const uint Id = 5673;
public uint MessageId
{
    get { return Id; }
}

public string name;
        public bool session;
        

public IgnoredAddRequestMessage()
{
}

public IgnoredAddRequestMessage(string name, bool session)
        {
            this.name = name;
            this.session = session;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(name);
            writer.WriteBoolean(session);
            

}

public void Deserialize(IDataReader reader)
{

name = reader.ReadUTF();
            session = reader.ReadBoolean();
            

}


}


}