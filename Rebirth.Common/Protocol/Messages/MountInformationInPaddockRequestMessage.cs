


















// Generated on 01/12/2017 03:52:56
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class MountInformationInPaddockRequestMessage : NetworkMessage
{

public const uint Id = 5975;
public uint MessageId
{
    get { return Id; }
}

public int mapRideId;
        

public MountInformationInPaddockRequestMessage()
{
}

public MountInformationInPaddockRequestMessage(int mapRideId)
        {
            this.mapRideId = mapRideId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)mapRideId);
            

}

public void Deserialize(IDataReader reader)
{

mapRideId = reader.ReadVarInt();
            

}


}


}