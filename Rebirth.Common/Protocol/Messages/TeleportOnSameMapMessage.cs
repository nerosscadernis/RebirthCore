


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class TeleportOnSameMapMessage : NetworkMessage
{

public const uint Id = 6048;
public uint MessageId
{
    get { return Id; }
}

public double targetId;
        public uint cellId;
        

public TeleportOnSameMapMessage()
{
}

public TeleportOnSameMapMessage(double targetId, uint cellId)
        {
            this.targetId = targetId;
            this.cellId = cellId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(targetId);
            writer.WriteVarShort((int)cellId);
            

}

public void Deserialize(IDataReader reader)
{

targetId = reader.ReadDouble();
            if (targetId < -9.007199254740992E15 || targetId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on targetId = " + targetId + ", it doesn't respect the following condition : targetId < -9.007199254740992E15 || targetId > 9.007199254740992E15");
            cellId = reader.ReadVarUhShort();
            if (cellId < 0 || cellId > 559)
                throw new System.Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
            

}


}


}