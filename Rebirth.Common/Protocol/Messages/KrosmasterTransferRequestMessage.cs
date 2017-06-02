


















// Generated on 01/12/2017 03:53:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class KrosmasterTransferRequestMessage : NetworkMessage
{

public const uint Id = 6349;
public uint MessageId
{
    get { return Id; }
}

public string uid;
        

public KrosmasterTransferRequestMessage()
{
}

public KrosmasterTransferRequestMessage(string uid)
        {
            this.uid = uid;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(uid);
            

}

public void Deserialize(IDataReader reader)
{

uid = reader.ReadUTF();
            

}


}


}