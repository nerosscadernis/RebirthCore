


















// Generated on 01/12/2017 03:52:53
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class AllianceInvitationStateRecruterMessage : NetworkMessage
{

public const uint Id = 6396;
public uint MessageId
{
    get { return Id; }
}

public string recrutedName;
        public sbyte invitationState;
        

public AllianceInvitationStateRecruterMessage()
{
}

public AllianceInvitationStateRecruterMessage(string recrutedName, sbyte invitationState)
        {
            this.recrutedName = recrutedName;
            this.invitationState = invitationState;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(recrutedName);
            writer.WriteSByte(invitationState);
            

}

public void Deserialize(IDataReader reader)
{

recrutedName = reader.ReadUTF();
            invitationState = reader.ReadSByte();
            if (invitationState < 0)
                throw new System.Exception("Forbidden value on invitationState = " + invitationState + ", it doesn't respect the following condition : invitationState < 0");
            

}


}


}