


















// Generated on 01/12/2017 03:52:56
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class MountRenameRequestMessage : NetworkMessage
{

public const uint Id = 5987;
public uint MessageId
{
    get { return Id; }
}

public string name;
        public int mountId;
        

public MountRenameRequestMessage()
{
}

public MountRenameRequestMessage(string name, int mountId)
        {
            this.name = name;
            this.mountId = mountId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(name);
            writer.WriteVarInt((int)mountId);
            

}

public void Deserialize(IDataReader reader)
{

name = reader.ReadUTF();
            mountId = reader.ReadVarInt();
            

}


}


}