


















// Generated on 01/12/2017 03:52:53
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class AllianceMotdSetErrorMessage : SocialNoticeSetErrorMessage
{

public const uint Id = 6683;
public uint MessageId
{
    get { return Id; }
}



public AllianceMotdSetErrorMessage()
{
}

public AllianceMotdSetErrorMessage(sbyte reason)
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