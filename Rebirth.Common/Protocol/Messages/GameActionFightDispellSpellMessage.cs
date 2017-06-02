


















// Generated on 01/12/2017 03:52:52
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionFightDispellSpellMessage : GameActionFightDispellMessage
{

public const uint Id = 6176;
public uint MessageId
{
    get { return Id; }
}

public uint spellId;
        

public GameActionFightDispellSpellMessage()
{
}

public GameActionFightDispellSpellMessage(uint actionId, double sourceId, double targetId, uint spellId)
         : base(actionId, sourceId, targetId)
        {
            this.spellId = spellId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)spellId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            spellId = reader.ReadVarUhShort();
            if (spellId < 0)
                throw new System.Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            

}


}


}