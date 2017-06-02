


















// Generated on 01/12/2017 03:52:58
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class JobCrafterDirectoryDefineSettingsMessage : NetworkMessage
{

public const uint Id = 5649;
public uint MessageId
{
    get { return Id; }
}

public Types.JobCrafterDirectorySettings settings;
        

public JobCrafterDirectoryDefineSettingsMessage()
{
}

public JobCrafterDirectoryDefineSettingsMessage(Types.JobCrafterDirectorySettings settings)
        {
            this.settings = settings;
        }
        

public void Serialize(IDataWriter writer)
{

settings.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

settings = new Types.JobCrafterDirectorySettings();
            settings.Deserialize(reader);
            

}


}


}