


















// Generated on 01/12/2017 03:52:56
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameRolePlayShowActorWithEventMessage : GameRolePlayShowActorMessage
{

public const uint Id = 6407;
public uint MessageId
{
    get { return Id; }
}

public sbyte actorEventId;
        

public GameRolePlayShowActorWithEventMessage()
{
}

public GameRolePlayShowActorWithEventMessage(Types.GameRolePlayActorInformations informations, sbyte actorEventId)
         : base(informations)
        {
            this.actorEventId = actorEventId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(actorEventId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            actorEventId = reader.ReadSByte();
            if (actorEventId < 0)
                throw new System.Exception("Forbidden value on actorEventId = " + actorEventId + ", it doesn't respect the following condition : actorEventId < 0");
            

}


}


}