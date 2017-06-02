


















// Generated on 01/12/2017 03:53:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class ObjectItemInRolePlay : NetworkType
{

public const short Id = 198;
public virtual short TypeId
{
    get { return Id; }
}

public uint cellId;
        public uint objectGID;
        

public ObjectItemInRolePlay()
{
}

public ObjectItemInRolePlay(uint cellId, uint objectGID)
        {
            this.cellId = cellId;
            this.objectGID = objectGID;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)cellId);
            writer.WriteVarShort((int)objectGID);
            

}

public virtual void Deserialize(IDataReader reader)
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