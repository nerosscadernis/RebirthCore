


















// Generated on 01/12/2017 03:52:54
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class CharactersListMessage : BasicCharactersListMessage
{

public const uint Id = 151;
public uint MessageId
{
    get { return Id; }
}

public bool hasStartupActions;
        

public CharactersListMessage()
{
}

public CharactersListMessage(Types.CharacterBaseInformations[] characters, bool hasStartupActions)
         : base(characters)
        {
            this.hasStartupActions = hasStartupActions;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(hasStartupActions);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            hasStartupActions = reader.ReadBoolean();
            

}


}


}