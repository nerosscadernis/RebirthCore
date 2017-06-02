


















// Generated on 01/12/2017 03:53:04
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ObjectUseOnCharacterMessage : ObjectUseMessage
{

public const uint Id = 3003;
public uint MessageId
{
    get { return Id; }
}

public double characterId;
        

public ObjectUseOnCharacterMessage()
{
}

public ObjectUseOnCharacterMessage(uint objectUID, double characterId)
         : base(objectUID)
        {
            this.characterId = characterId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(characterId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            characterId = reader.ReadVarUhLong();
            if (characterId < 0 || characterId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on characterId = " + characterId + ", it doesn't respect the following condition : characterId < 0 || characterId > 9.007199254740992E15");
            

}


}


}