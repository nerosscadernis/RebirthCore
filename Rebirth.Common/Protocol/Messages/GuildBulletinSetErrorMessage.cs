


















// Generated on 01/12/2017 03:53:00
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GuildBulletinSetErrorMessage : SocialNoticeSetErrorMessage
{

public const uint Id = 6691;
public uint MessageId
{
    get { return Id; }
}



public GuildBulletinSetErrorMessage()
{
}

public GuildBulletinSetErrorMessage(sbyte reason)
         : base(reason)
        {
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}