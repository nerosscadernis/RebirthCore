


















// Generated on 01/12/2017 03:53:04
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectsAddedMessage : NetworkMessage
{

public const uint Id = 6033;
public uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem[] @object;
        

public ObjectsAddedMessage()
{
}

public ObjectsAddedMessage(Types.ObjectItem[] @object)
        {
            this.@object = @object;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)@object.Length);
            foreach (var entry in @object)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            @object = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 @object[i] = new Types.ObjectItem();
                 @object[i].Deserialize(reader);
            }
            

}


}


}