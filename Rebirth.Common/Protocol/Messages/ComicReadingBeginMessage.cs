


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ComicReadingBeginMessage : NetworkMessage
{

public const uint Id = 6536;
public uint MessageId
{
    get { return Id; }
}

public uint comicId;
        

public ComicReadingBeginMessage()
{
}

public ComicReadingBeginMessage(uint comicId)
        {
            this.comicId = comicId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)comicId);
            

}

public void Deserialize(IDataReader reader)
{

comicId = reader.ReadVarUhShort();
            if (comicId < 0)
                throw new System.Exception("Forbidden value on comicId = " + comicId + ", it doesn't respect the following condition : comicId < 0");
            

}


}


}