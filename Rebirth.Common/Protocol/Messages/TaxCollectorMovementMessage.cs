


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class TaxCollectorMovementMessage : NetworkMessage
{

public const uint Id = 5633;
public uint MessageId
{
    get { return Id; }
}

public sbyte movementType;
        public Types.TaxCollectorBasicInformations basicInfos;
        public double playerId;
        public string playerName;
        

public TaxCollectorMovementMessage()
{
}

public TaxCollectorMovementMessage(sbyte movementType, Types.TaxCollectorBasicInformations basicInfos, double playerId, string playerName)
        {
            this.movementType = movementType;
            this.basicInfos = basicInfos;
            this.playerId = playerId;
            this.playerName = playerName;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(movementType);
            basicInfos.Serialize(writer);
            writer.WriteVarLong(playerId);
            writer.WriteUTF(playerName);
            

}

public void Deserialize(IDataReader reader)
{

movementType = reader.ReadSByte();
            if (movementType < 0)
                throw new System.Exception("Forbidden value on movementType = " + movementType + ", it doesn't respect the following condition : movementType < 0");
            basicInfos = new Types.TaxCollectorBasicInformations();
            basicInfos.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
            if (playerId < 0 || playerId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0 || playerId > 9.007199254740992E15");
            playerName = reader.ReadUTF();
            

}


}


}