


















// Generated on 01/12/2017 03:53:04
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class WrapperObjectDissociateRequestMessage : NetworkMessage
{

public const uint Id = 6524;
public uint MessageId
{
    get { return Id; }
}

public uint hostUID;
        public byte hostPos;
        

public WrapperObjectDissociateRequestMessage()
{
}

public WrapperObjectDissociateRequestMessage(uint hostUID, byte hostPos)
        {
            this.hostUID = hostUID;
            this.hostPos = hostPos;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)hostUID);
            writer.WriteByte(hostPos);
            

}

public void Deserialize(IDataReader reader)
{

hostUID = reader.ReadVarUhInt();
            if (hostUID < 0)
                throw new System.Exception("Forbidden value on hostUID = " + hostUID + ", it doesn't respect the following condition : hostUID < 0");
            hostPos = reader.ReadByte();
            if (hostPos < 0 || hostPos > 255)
                throw new System.Exception("Forbidden value on hostPos = " + hostPos + ", it doesn't respect the following condition : hostPos < 0 || hostPos > 255");
            

}


}


}