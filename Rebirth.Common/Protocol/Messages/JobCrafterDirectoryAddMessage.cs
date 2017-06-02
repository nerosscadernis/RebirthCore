


















// Generated on 01/12/2017 03:52:58
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class JobCrafterDirectoryAddMessage : NetworkMessage
{

public const uint Id = 5651;
public uint MessageId
{
    get { return Id; }
}

public Types.JobCrafterDirectoryListEntry listEntry;
        

public JobCrafterDirectoryAddMessage()
{
}

public JobCrafterDirectoryAddMessage(Types.JobCrafterDirectoryListEntry listEntry)
        {
            this.listEntry = listEntry;
        }
        

public void Serialize(IDataWriter writer)
{

listEntry.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

listEntry = new Types.JobCrafterDirectoryListEntry();
            listEntry.Deserialize(reader);
            

}


}


}