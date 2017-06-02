


















// Generated on 01/12/2017 03:52:53
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class AllianceInvitationMessage : NetworkMessage
{

public const uint Id = 6395;
public uint MessageId
{
    get { return Id; }
}

public double targetId;
        

public AllianceInvitationMessage()
{
}

public AllianceInvitationMessage(double targetId)
        {
            this.targetId = targetId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(targetId);
            

}

public void Deserialize(IDataReader reader)
{

targetId = reader.ReadVarUhLong();
            if (targetId < 0 || targetId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on targetId = " + targetId + ", it doesn't respect the following condition : targetId < 0 || targetId > 9.007199254740992E15");
            

}


}


}