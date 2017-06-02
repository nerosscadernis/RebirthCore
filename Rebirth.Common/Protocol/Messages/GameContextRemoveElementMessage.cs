


















// Generated on 01/12/2017 03:52:55
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameContextRemoveElementMessage : NetworkMessage
{

public const uint Id = 251;
public uint MessageId
{
    get { return Id; }
}

public double id;
        

public GameContextRemoveElementMessage()
{
}

public GameContextRemoveElementMessage(double id)
        {
            this.id = id;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(id);
            

}

public void Deserialize(IDataReader reader)
{

id = reader.ReadDouble();
            if (id < -9.007199254740992E15 || id > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < -9.007199254740992E15 || id > 9.007199254740992E15");
            

}


}


}