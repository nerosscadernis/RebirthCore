


















// Generated on 01/12/2017 03:52:58
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectGroundRemovedMessage : NetworkMessage
{

public const uint Id = 3014;
public uint MessageId
{
    get { return Id; }
}

public uint cell;
        

public ObjectGroundRemovedMessage()
{
}

public ObjectGroundRemovedMessage(uint cell)
        {
            this.cell = cell;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)cell);
            

}

public void Deserialize(IDataReader reader)
{

cell = reader.ReadVarUhShort();
            if (cell < 0 || cell > 559)
                throw new System.Exception("Forbidden value on cell = " + cell + ", it doesn't respect the following condition : cell < 0 || cell > 559");
            

}


}


}