


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class HavenBagDailyLoteryMessage : NetworkMessage
{

public const uint Id = 6644;
public uint MessageId
{
    get { return Id; }
}

public string tokenId;
        

public HavenBagDailyLoteryMessage()
{
}

public HavenBagDailyLoteryMessage(string tokenId)
        {
            this.tokenId = tokenId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(tokenId);
            

}

public void Deserialize(IDataReader reader)
{

tokenId = reader.ReadUTF();
            

}


}


}