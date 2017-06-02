


















// Generated on 01/12/2017 03:53:05
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class TitleGainedMessage : NetworkMessage
{

public const uint Id = 6364;
public uint MessageId
{
    get { return Id; }
}

public uint titleId;
        

public TitleGainedMessage()
{
}

public TitleGainedMessage(uint titleId)
        {
            this.titleId = titleId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)titleId);
            

}

public void Deserialize(IDataReader reader)
{

titleId = reader.ReadVarUhShort();
            if (titleId < 0)
                throw new System.Exception("Forbidden value on titleId = " + titleId + ", it doesn't respect the following condition : titleId < 0");
            

}


}


}