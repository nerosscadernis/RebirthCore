


















// Generated on 01/12/2017 03:53:05
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class StartupActionsObjetAttributionMessage : NetworkMessage
{

public const uint Id = 1303;
public uint MessageId
{
    get { return Id; }
}

public int actionId;
        public double characterId;
        

public StartupActionsObjetAttributionMessage()
{
}

public StartupActionsObjetAttributionMessage(int actionId, double characterId)
        {
            this.actionId = actionId;
            this.characterId = characterId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(actionId);
            writer.WriteVarLong(characterId);
            

}

public void Deserialize(IDataReader reader)
{

actionId = reader.ReadInt();
            if (actionId < 0)
                throw new System.Exception("Forbidden value on actionId = " + actionId + ", it doesn't respect the following condition : actionId < 0");
            characterId = reader.ReadVarUhLong();
            if (characterId < 0 || characterId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on characterId = " + characterId + ", it doesn't respect the following condition : characterId < 0 || characterId > 9.007199254740992E15");
            

}


}


}