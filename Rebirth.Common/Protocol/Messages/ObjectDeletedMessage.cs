


















// Generated on 01/12/2017 03:53:03
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectDeletedMessage : NetworkMessage
{

public const uint Id = 3024;
public uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        

public ObjectDeletedMessage()
{
}

public ObjectDeletedMessage(uint objectUID)
        {
            this.objectUID = objectUID;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectUID);
            

}

public void Deserialize(IDataReader reader)
{

objectUID = reader.ReadVarUhInt();
            if (objectUID < 0)
                throw new System.Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            

}


}


}