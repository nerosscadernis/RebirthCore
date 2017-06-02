


















// Generated on 01/12/2017 03:52:55
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ChatSmileyMessage : NetworkMessage
{

public const uint Id = 801;
public uint MessageId
{
    get { return Id; }
}

public double entityId;
        public uint smileyId;
        public int accountId;
        

public ChatSmileyMessage()
{
}

public ChatSmileyMessage(double entityId, uint smileyId, int accountId)
        {
            this.entityId = entityId;
            this.smileyId = smileyId;
            this.accountId = accountId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(entityId);
            writer.WriteVarShort((int)smileyId);
            writer.WriteInt(accountId);
            

}

public void Deserialize(IDataReader reader)
{

entityId = reader.ReadDouble();
            if (entityId < -9.007199254740992E15 || entityId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on entityId = " + entityId + ", it doesn't respect the following condition : entityId < -9.007199254740992E15 || entityId > 9.007199254740992E15");
            smileyId = reader.ReadVarUhShort();
            if (smileyId < 0)
                throw new System.Exception("Forbidden value on smileyId = " + smileyId + ", it doesn't respect the following condition : smileyId < 0");
            accountId = reader.ReadInt();
            if (accountId < 0)
                throw new System.Exception("Forbidden value on accountId = " + accountId + ", it doesn't respect the following condition : accountId < 0");
            

}


}


}