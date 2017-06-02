


















// Generated on 01/12/2017 03:52:55
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameContextCreateMessage : NetworkMessage
{

public const uint Id = 200;
public uint MessageId
{
    get { return Id; }
}

public sbyte context;
        

public GameContextCreateMessage()
{
}

public GameContextCreateMessage(sbyte context)
        {
            this.context = context;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(context);
            

}

public void Deserialize(IDataReader reader)
{

context = reader.ReadSByte();
            if (context < 0)
                throw new System.Exception("Forbidden value on context = " + context + ", it doesn't respect the following condition : context < 0");
            

}


}


}