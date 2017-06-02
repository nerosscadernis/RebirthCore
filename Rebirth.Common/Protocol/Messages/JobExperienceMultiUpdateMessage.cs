


















// Generated on 01/12/2017 03:52:58
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class JobExperienceMultiUpdateMessage : NetworkMessage
{

public const uint Id = 5809;
public uint MessageId
{
    get { return Id; }
}

public Types.JobExperience[] experiencesUpdate;
        

public JobExperienceMultiUpdateMessage()
{
}

public JobExperienceMultiUpdateMessage(Types.JobExperience[] experiencesUpdate)
        {
            this.experiencesUpdate = experiencesUpdate;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)experiencesUpdate.Length);
            foreach (var entry in experiencesUpdate)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            experiencesUpdate = new Types.JobExperience[limit];
            for (int i = 0; i < limit; i++)
            {
                 experiencesUpdate[i] = new Types.JobExperience();
                 experiencesUpdate[i].Deserialize(reader);
            }
            

}


}


}