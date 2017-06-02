


















// Generated on 01/12/2017 03:52:58
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class TaxCollectorDialogQuestionBasicMessage : NetworkMessage
{

public const uint Id = 5619;
public uint MessageId
{
    get { return Id; }
}

public Types.BasicGuildInformations guildInfo;
        

public TaxCollectorDialogQuestionBasicMessage()
{
}

public TaxCollectorDialogQuestionBasicMessage(Types.BasicGuildInformations guildInfo)
        {
            this.guildInfo = guildInfo;
        }
        

public void Serialize(IDataWriter writer)
{

guildInfo.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

guildInfo = new Types.BasicGuildInformations();
            guildInfo.Deserialize(reader);
            

}


}


}