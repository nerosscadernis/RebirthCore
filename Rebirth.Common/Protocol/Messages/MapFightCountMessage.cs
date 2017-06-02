


















// Generated on 01/12/2017 03:52:56
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class MapFightCountMessage : NetworkMessage
{

public const uint Id = 210;
public uint MessageId
{
    get { return Id; }
}

public uint fightCount;
        

public MapFightCountMessage()
{
}

public MapFightCountMessage(uint fightCount)
        {
            this.fightCount = fightCount;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)fightCount);
            

}

public void Deserialize(IDataReader reader)
{

fightCount = reader.ReadVarUhShort();
            if (fightCount < 0)
                throw new System.Exception("Forbidden value on fightCount = " + fightCount + ", it doesn't respect the following condition : fightCount < 0");
            

}


}


}