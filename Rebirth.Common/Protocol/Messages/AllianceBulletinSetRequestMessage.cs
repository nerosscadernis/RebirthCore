


















// Generated on 01/12/2017 03:52:53
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class AllianceBulletinSetRequestMessage : SocialNoticeSetRequestMessage
{

public const uint Id = 6693;
public uint MessageId
{
    get { return Id; }
}

public string content;
        public bool notifyMembers;
        

public AllianceBulletinSetRequestMessage()
{
}

public AllianceBulletinSetRequestMessage(string content, bool notifyMembers)
        {
            this.content = content;
            this.notifyMembers = notifyMembers;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(content);
            writer.WriteBoolean(notifyMembers);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            content = reader.ReadUTF();
            notifyMembers = reader.ReadBoolean();
            

}


}


}