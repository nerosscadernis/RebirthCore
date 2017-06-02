


















// Generated on 01/12/2017 03:52:58
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class LockableStateUpdateHouseDoorMessage : LockableStateUpdateAbstractMessage
{

public const uint Id = 5668;
public uint MessageId
{
    get { return Id; }
}

public uint houseId;
        

public LockableStateUpdateHouseDoorMessage()
{
}

public LockableStateUpdateHouseDoorMessage(bool locked, uint houseId)
         : base(locked)
        {
            this.houseId = houseId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)houseId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            houseId = reader.ReadVarUhInt();
            if (houseId < 0)
                throw new System.Exception("Forbidden value on houseId = " + houseId + ", it doesn't respect the following condition : houseId < 0");
            

}


}


}