


















// Generated on 01/12/2017 03:52:58
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectGroundAddedMessage : NetworkMessage
{

public const uint Id = 3017;
public uint MessageId
{
    get { return Id; }
}

public uint cellId;
        public uint objectGID;
        

public ObjectGroundAddedMessage()
{
}

public ObjectGroundAddedMessage(uint cellId, uint objectGID)
        {
            this.cellId = cellId;
            this.objectGID = objectGID;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)cellId);
            writer.WriteVarShort((int)objectGID);
            

}

public void Deserialize(IDataReader reader)
{

cellId = reader.ReadVarUhShort();
            if (cellId < 0 || cellId > 559)
                throw new System.Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
            objectGID = reader.ReadVarUhShort();
            if (objectGID < 0)
                throw new System.Exception("Forbidden value on objectGID = " + objectGID + ", it doesn't respect the following condition : objectGID < 0");
            

}


}


}