


















// Generated on 01/12/2017 03:53:04
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectUseOnCellMessage : ObjectUseMessage
{

public const uint Id = 3013;
public uint MessageId
{
    get { return Id; }
}

public uint cells;
        

public ObjectUseOnCellMessage()
{
}

public ObjectUseOnCellMessage(uint objectUID, uint cells)
         : base(objectUID)
        {
            this.cells = cells;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)cells);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            cells = reader.ReadVarUhShort();
            if (cells < 0 || cells > 559)
                throw new System.Exception("Forbidden value on cells = " + cells + ", it doesn't respect the following condition : cells < 0 || cells > 559");
            

}


}


}