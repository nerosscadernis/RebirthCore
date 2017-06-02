


















// Generated on 01/12/2017 03:52:54
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class CharacterSelectedForceMessage : NetworkMessage
{

public const uint Id = 6068;
public uint MessageId
{
    get { return Id; }
}

public int id;
        

public CharacterSelectedForceMessage()
{
}

public CharacterSelectedForceMessage(int id)
        {
            this.id = id;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(id);
            

}

public void Deserialize(IDataReader reader)
{

id = reader.ReadInt();
            if (id < 1 || id > 2147483647)
                throw new System.Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 1 || id > 2147483647");
            

}


}


}