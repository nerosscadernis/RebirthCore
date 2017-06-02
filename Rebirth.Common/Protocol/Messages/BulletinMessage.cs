


















// Generated on 01/12/2017 03:53:05
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class BulletinMessage : SocialNoticeMessage
{

public const uint Id = 6695;
public uint MessageId
{
    get { return Id; }
}

public int lastNotifiedTimestamp;
        

public BulletinMessage()
{
}

public BulletinMessage(string content, int timestamp, double memberId, string memberName, int lastNotifiedTimestamp)
         : base(content, timestamp, memberId, memberName)
        {
            this.lastNotifiedTimestamp = lastNotifiedTimestamp;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(lastNotifiedTimestamp);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            lastNotifiedTimestamp = reader.ReadInt();
            if (lastNotifiedTimestamp < 0)
                throw new System.Exception("Forbidden value on lastNotifiedTimestamp = " + lastNotifiedTimestamp + ", it doesn't respect the following condition : lastNotifiedTimestamp < 0");
            

}


}


}