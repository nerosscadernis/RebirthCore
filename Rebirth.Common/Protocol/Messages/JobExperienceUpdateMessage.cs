


















// Generated on 01/12/2017 03:52:58
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class JobExperienceUpdateMessage : NetworkMessage
{

public const uint Id = 5654;
public uint MessageId
{
    get { return Id; }
}

public Types.JobExperience experiencesUpdate;
        

public JobExperienceUpdateMessage()
{
}

public JobExperienceUpdateMessage(Types.JobExperience experiencesUpdate)
        {
            this.experiencesUpdate = experiencesUpdate;
        }
        

public void Serialize(IDataWriter writer)
{

experiencesUpdate.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

experiencesUpdate = new Types.JobExperience();
            experiencesUpdate.Deserialize(reader);
            

}


}


}