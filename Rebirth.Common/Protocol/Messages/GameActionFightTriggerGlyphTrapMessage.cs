


















// Generated on 01/12/2017 03:52:53
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionFightTriggerGlyphTrapMessage : AbstractGameActionMessage
{

public const uint Id = 5741;
public uint MessageId
{
    get { return Id; }
}

public short markId;
        public double triggeringCharacterId;
        public uint triggeredSpellId;
        

public GameActionFightTriggerGlyphTrapMessage()
{
}

public GameActionFightTriggerGlyphTrapMessage(uint actionId, double sourceId, short markId, double triggeringCharacterId, uint triggeredSpellId)
         : base(actionId, sourceId)
        {
            this.markId = markId;
            this.triggeringCharacterId = triggeringCharacterId;
            this.triggeredSpellId = triggeredSpellId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(markId);
            writer.WriteDouble(triggeringCharacterId);
            writer.WriteVarShort((int)triggeredSpellId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            markId = reader.ReadShort();
            triggeringCharacterId = reader.ReadDouble();
            if (triggeringCharacterId < -9.007199254740992E15 || triggeringCharacterId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on triggeringCharacterId = " + triggeringCharacterId + ", it doesn't respect the following condition : triggeringCharacterId < -9.007199254740992E15 || triggeringCharacterId > 9.007199254740992E15");
            triggeredSpellId = reader.ReadVarUhShort();
            if (triggeredSpellId < 0)
                throw new System.Exception("Forbidden value on triggeredSpellId = " + triggeredSpellId + ", it doesn't respect the following condition : triggeredSpellId < 0");
            

}


}


}