


















// Generated on 01/12/2017 03:53:05
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class PrismsListRegisterMessage : NetworkMessage
{

public const uint Id = 6441;
public uint MessageId
{
    get { return Id; }
}

public sbyte listen;
        

public PrismsListRegisterMessage()
{
}

public PrismsListRegisterMessage(sbyte listen)
        {
            this.listen = listen;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(listen);
            

}

public void Deserialize(IDataReader reader)
{

listen = reader.ReadSByte();
            if (listen < 0)
                throw new System.Exception("Forbidden value on listen = " + listen + ", it doesn't respect the following condition : listen < 0");
            

}


}


}