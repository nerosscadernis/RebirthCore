


















// Generated on 01/12/2017 03:52:52
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class AdminCommandMessage : NetworkMessage
{

public const uint Id = 76;
public uint MessageId
{
    get { return Id; }
}

public string content;
        

public AdminCommandMessage()
{
}

public AdminCommandMessage(string content)
        {
            this.content = content;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(content);
            

}

public void Deserialize(IDataReader reader)
{

content = reader.ReadUTF();
            

}


}


}