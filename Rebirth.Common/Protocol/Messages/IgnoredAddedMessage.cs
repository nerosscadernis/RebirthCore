


















// Generated on 01/12/2017 03:53:00
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class IgnoredAddedMessage : NetworkMessage
{

public const uint Id = 5678;
public uint MessageId
{
    get { return Id; }
}

public Types.IgnoredInformations ignoreAdded;
        public bool session;
        

public IgnoredAddedMessage()
{
}

public IgnoredAddedMessage(Types.IgnoredInformations ignoreAdded, bool session)
        {
            this.ignoreAdded = ignoreAdded;
            this.session = session;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(ignoreAdded.TypeId);
            ignoreAdded.Serialize(writer);
            writer.WriteBoolean(session);
            

}

public void Deserialize(IDataReader reader)
{

ignoreAdded = ProtocolTypeManager.GetInstance<Types.IgnoredInformations>(reader.ReadShort());
            ignoreAdded.Deserialize(reader);
            session = reader.ReadBoolean();
            

}


}


}