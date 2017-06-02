


















// Generated on 01/12/2017 03:52:54
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class BasicCharactersListMessage : NetworkMessage
{

public const uint Id = 6475;
public uint MessageId
{
    get { return Id; }
}

public Types.CharacterBaseInformations[] characters;
        

public BasicCharactersListMessage()
{
}

public BasicCharactersListMessage(Types.CharacterBaseInformations[] characters)
        {
            this.characters = characters;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)characters.Length);
            foreach (var entry in characters)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            characters = new Types.CharacterBaseInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 characters[i] = ProtocolTypeManager.GetInstance<Types.CharacterBaseInformations>(reader.ReadShort());
                 characters[i].Deserialize(reader);
            }
            

}


}


}