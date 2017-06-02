


















// Generated on 01/12/2017 03:52:59
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class SpellModifySuccessMessage : NetworkMessage
{

public const uint Id = 6654;
public uint MessageId
{
    get { return Id; }
}

public int spellId;
        public short spellLevel;
        

public SpellModifySuccessMessage()
{
}

public SpellModifySuccessMessage(int spellId, short spellLevel)
        {
            this.spellId = spellId;
            this.spellLevel = spellLevel;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(spellId);
            writer.WriteShort(spellLevel);
            

}

public void Deserialize(IDataReader reader)
{

spellId = reader.ReadInt();
            spellLevel = reader.ReadShort();
            if (spellLevel < 1 || spellLevel > 200)
                throw new System.Exception("Forbidden value on spellLevel = " + spellLevel + ", it doesn't respect the following condition : spellLevel < 1 || spellLevel > 200");
            

}


}


}