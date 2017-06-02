


















// Generated on 01/12/2017 03:53:05
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class DownloadCurrentSpeedMessage : NetworkMessage
{

public const uint Id = 1511;
public uint MessageId
{
    get { return Id; }
}

public sbyte downloadSpeed;
        

public DownloadCurrentSpeedMessage()
{
}

public DownloadCurrentSpeedMessage(sbyte downloadSpeed)
        {
            this.downloadSpeed = downloadSpeed;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(downloadSpeed);
            

}

public void Deserialize(IDataReader reader)
{

downloadSpeed = reader.ReadSByte();
            if (downloadSpeed < 1 || downloadSpeed > 10)
                throw new System.Exception("Forbidden value on downloadSpeed = " + downloadSpeed + ", it doesn't respect the following condition : downloadSpeed < 1 || downloadSpeed > 10");
            

}


}


}