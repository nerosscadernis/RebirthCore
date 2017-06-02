


















// Generated on 01/12/2017 03:52:55
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightOptionToggleMessage : NetworkMessage
{

public const uint Id = 707;
public uint MessageId
{
    get { return Id; }
}

public sbyte option;
        

public GameFightOptionToggleMessage()
{
}

public GameFightOptionToggleMessage(sbyte option)
        {
            this.option = option;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(option);
            

}

public void Deserialize(IDataReader reader)
{

option = reader.ReadSByte();
            if (option < 0)
                throw new System.Exception("Forbidden value on option = " + option + ", it doesn't respect the following condition : option < 0");
            

}


}


}