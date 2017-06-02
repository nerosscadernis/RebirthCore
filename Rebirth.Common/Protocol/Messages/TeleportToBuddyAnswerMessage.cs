


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class TeleportToBuddyAnswerMessage : NetworkMessage
{

public const uint Id = 6293;
public uint MessageId
{
    get { return Id; }
}

public uint dungeonId;
        public double buddyId;
        public bool accept;
        

public TeleportToBuddyAnswerMessage()
{
}

public TeleportToBuddyAnswerMessage(uint dungeonId, double buddyId, bool accept)
        {
            this.dungeonId = dungeonId;
            this.buddyId = buddyId;
            this.accept = accept;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)dungeonId);
            writer.WriteVarLong(buddyId);
            writer.WriteBoolean(accept);
            

}

public void Deserialize(IDataReader reader)
{

dungeonId = reader.ReadVarUhShort();
            if (dungeonId < 0)
                throw new System.Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            buddyId = reader.ReadVarUhLong();
            if (buddyId < 0 || buddyId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on buddyId = " + buddyId + ", it doesn't respect the following condition : buddyId < 0 || buddyId > 9.007199254740992E15");
            accept = reader.ReadBoolean();
            

}


}


}