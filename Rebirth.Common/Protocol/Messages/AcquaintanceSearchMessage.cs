


















// Generated on 01/12/2017 03:52:52
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class AcquaintanceSearchMessage : NetworkMessage
{

public const uint Id = 6144;
public uint MessageId
{
    get { return Id; }
}

public string nickname;
        

public AcquaintanceSearchMessage()
{
}

public AcquaintanceSearchMessage(string nickname)
        {
            this.nickname = nickname;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(nickname);
            

}

public void Deserialize(IDataReader reader)
{

nickname = reader.ReadUTF();
            

}


}


}