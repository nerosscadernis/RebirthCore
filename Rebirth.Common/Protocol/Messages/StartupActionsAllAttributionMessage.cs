


















// Generated on 01/12/2017 03:53:05
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class StartupActionsAllAttributionMessage : NetworkMessage
{

public const uint Id = 6537;
public uint MessageId
{
    get { return Id; }
}

public double characterId;
        

public StartupActionsAllAttributionMessage()
{
}

public StartupActionsAllAttributionMessage(double characterId)
        {
            this.characterId = characterId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(characterId);
            

}

public void Deserialize(IDataReader reader)
{

characterId = reader.ReadVarUhLong();
            if (characterId < 0 || characterId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on characterId = " + characterId + ", it doesn't respect the following condition : characterId < 0 || characterId > 9.007199254740992E15");
            

}


}


}