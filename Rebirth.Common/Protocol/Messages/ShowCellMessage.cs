


















// Generated on 01/12/2017 03:52:55
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ShowCellMessage : NetworkMessage
{

public const uint Id = 5612;
public uint MessageId
{
    get { return Id; }
}

public double sourceId;
        public uint cellId;
        

public ShowCellMessage()
{
}

public ShowCellMessage(double sourceId, uint cellId)
        {
            this.sourceId = sourceId;
            this.cellId = cellId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(sourceId);
            writer.WriteVarShort((int)cellId);
            

}

public void Deserialize(IDataReader reader)
{

sourceId = reader.ReadDouble();
            if (sourceId < -9.007199254740992E15 || sourceId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on sourceId = " + sourceId + ", it doesn't respect the following condition : sourceId < -9.007199254740992E15 || sourceId > 9.007199254740992E15");
            cellId = reader.ReadVarUhShort();
            if (cellId < 0 || cellId > 559)
                throw new System.Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
            

}


}


}