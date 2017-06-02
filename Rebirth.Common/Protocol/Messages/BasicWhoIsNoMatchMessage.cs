


















// Generated on 01/12/2017 03:52:54
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class BasicWhoIsNoMatchMessage : NetworkMessage
{

public const uint Id = 179;
public uint MessageId
{
    get { return Id; }
}

public string search;
        

public BasicWhoIsNoMatchMessage()
{
}

public BasicWhoIsNoMatchMessage(string search)
        {
            this.search = search;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(search);
            

}

public void Deserialize(IDataReader reader)
{

search = reader.ReadUTF();
            

}


}


}