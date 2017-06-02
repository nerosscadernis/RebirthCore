


















// Generated on 01/12/2017 03:52:58
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class LockableChangeCodeMessage : NetworkMessage
{

public const uint Id = 5666;
public uint MessageId
{
    get { return Id; }
}

public string code;
        

public LockableChangeCodeMessage()
{
}

public LockableChangeCodeMessage(string code)
        {
            this.code = code;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(code);
            

}

public void Deserialize(IDataReader reader)
{

code = reader.ReadUTF();
            

}


}


}