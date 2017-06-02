


















// Generated on 01/12/2017 03:53:05
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ContactLookRequestByNameMessage : ContactLookRequestMessage
{

public const uint Id = 5933;
public uint MessageId
{
    get { return Id; }
}

public string playerName;
        

public ContactLookRequestByNameMessage()
{
}

public ContactLookRequestByNameMessage(byte requestId, sbyte contactType, string playerName)
         : base(requestId, contactType)
        {
            this.playerName = playerName;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(playerName);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            playerName = reader.ReadUTF();
            

}


}


}