


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ServerExperienceModificatorMessage : NetworkMessage
{

public const uint Id = 6237;
public uint MessageId
{
    get { return Id; }
}

public uint experiencePercent;
        

public ServerExperienceModificatorMessage()
{
}

public ServerExperienceModificatorMessage(uint experiencePercent)
        {
            this.experiencePercent = experiencePercent;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)experiencePercent);
            

}

public void Deserialize(IDataReader reader)
{

experiencePercent = reader.ReadVarUhShort();
            if (experiencePercent < 0)
                throw new System.Exception("Forbidden value on experiencePercent = " + experiencePercent + ", it doesn't respect the following condition : experiencePercent < 0");
            

}


}


}