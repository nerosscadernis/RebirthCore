


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class SetCharacterRestrictionsMessage : NetworkMessage
{

public const uint Id = 170;
public uint MessageId
{
    get { return Id; }
}

public double actorId;
        public Types.ActorRestrictionsInformations restrictions;
        

public SetCharacterRestrictionsMessage()
{
}

public SetCharacterRestrictionsMessage(double actorId, Types.ActorRestrictionsInformations restrictions)
        {
            this.actorId = actorId;
            this.restrictions = restrictions;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(actorId);
            restrictions.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

actorId = reader.ReadDouble();
            if (actorId < -9.007199254740992E15 || actorId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on actorId = " + actorId + ", it doesn't respect the following condition : actorId < -9.007199254740992E15 || actorId > 9.007199254740992E15");
            restrictions = new Types.ActorRestrictionsInformations();
            restrictions.Deserialize(reader);
            

}


}


}