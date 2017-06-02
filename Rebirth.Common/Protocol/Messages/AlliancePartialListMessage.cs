


















// Generated on 01/12/2017 03:52:53
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class AlliancePartialListMessage : AllianceListMessage
{

public const uint Id = 6427;
public uint MessageId
{
    get { return Id; }
}



public AlliancePartialListMessage()
{
}

public AlliancePartialListMessage(Types.AllianceFactSheetInformations[] alliances)
         : base(alliances)
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