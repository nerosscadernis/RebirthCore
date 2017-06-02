


















// Generated on 01/12/2017 03:53:05
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class PartInfoMessage : NetworkMessage
{

public const uint Id = 1508;
public uint MessageId
{
    get { return Id; }
}

public Types.ContentPart part;
        public float installationPercent;
        

public PartInfoMessage()
{
}

public PartInfoMessage(Types.ContentPart part, float installationPercent)
        {
            this.part = part;
            this.installationPercent = installationPercent;
        }
        

public void Serialize(IDataWriter writer)
{

part.Serialize(writer);
            writer.WriteFloat(installationPercent);
            

}

public void Deserialize(IDataReader reader)
{

part = new Types.ContentPart();
            part.Deserialize(reader);
            installationPercent = reader.ReadFloat();
            

}


}


}