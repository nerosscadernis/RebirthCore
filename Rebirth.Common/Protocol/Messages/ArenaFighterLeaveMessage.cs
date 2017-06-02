


















// Generated on 01/12/2017 03:52:56
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ArenaFighterLeaveMessage : NetworkMessage
{

public const uint Id = 6700;
public uint MessageId
{
    get { return Id; }
}

public Types.CharacterBasicMinimalInformations leaver;
        

public ArenaFighterLeaveMessage()
{
}

public ArenaFighterLeaveMessage(Types.CharacterBasicMinimalInformations leaver)
        {
            this.leaver = leaver;
        }
        

public void Serialize(IDataWriter writer)
{

leaver.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

leaver = new Types.CharacterBasicMinimalInformations();
            leaver.Deserialize(reader);
            

}


}


}