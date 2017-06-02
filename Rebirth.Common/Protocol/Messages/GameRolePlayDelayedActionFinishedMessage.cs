


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayDelayedActionFinishedMessage : NetworkMessage
{

public const uint Id = 6150;
public uint MessageId
{
    get { return Id; }
}

public double delayedCharacterId;
        public sbyte delayTypeId;
        

public GameRolePlayDelayedActionFinishedMessage()
{
}

public GameRolePlayDelayedActionFinishedMessage(double delayedCharacterId, sbyte delayTypeId)
        {
            this.delayedCharacterId = delayedCharacterId;
            this.delayTypeId = delayTypeId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(delayedCharacterId);
            writer.WriteSByte(delayTypeId);
            

}

public void Deserialize(IDataReader reader)
{

delayedCharacterId = reader.ReadDouble();
            if (delayedCharacterId < -9.007199254740992E15 || delayedCharacterId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on delayedCharacterId = " + delayedCharacterId + ", it doesn't respect the following condition : delayedCharacterId < -9.007199254740992E15 || delayedCharacterId > 9.007199254740992E15");
            delayTypeId = reader.ReadSByte();
            if (delayTypeId < 0)
                throw new System.Exception("Forbidden value on delayTypeId = " + delayTypeId + ", it doesn't respect the following condition : delayTypeId < 0");
            

}


}


}