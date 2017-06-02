


















// Generated on 01/12/2017 03:52:54
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class CharacterReplayWithRemodelRequestMessage : CharacterReplayRequestMessage
{

public const uint Id = 6551;
public uint MessageId
{
    get { return Id; }
}

public Types.RemodelingInformation remodel;
        

public CharacterReplayWithRemodelRequestMessage()
{
}

public CharacterReplayWithRemodelRequestMessage(double characterId, Types.RemodelingInformation remodel)
         : base(characterId)
        {
            this.remodel = remodel;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            remodel.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            remodel = new Types.RemodelingInformation();
            remodel.Deserialize(reader);
            

}


}


}