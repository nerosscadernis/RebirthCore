


















// Generated on 01/12/2017 03:53:05
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class UpdateSelfAgressableStatusMessage : NetworkMessage
{

public const uint Id = 6456;
public uint MessageId
{
    get { return Id; }
}

public sbyte status;
        public int probationTime;
        

public UpdateSelfAgressableStatusMessage()
{
}

public UpdateSelfAgressableStatusMessage(sbyte status, int probationTime)
        {
            this.status = status;
            this.probationTime = probationTime;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(status);
            writer.WriteInt(probationTime);
            

}

public void Deserialize(IDataReader reader)
{

status = reader.ReadSByte();
            if (status < 0)
                throw new System.Exception("Forbidden value on status = " + status + ", it doesn't respect the following condition : status < 0");
            probationTime = reader.ReadInt();
            if (probationTime < 0)
                throw new System.Exception("Forbidden value on probationTime = " + probationTime + ", it doesn't respect the following condition : probationTime < 0");
            

}


}


}