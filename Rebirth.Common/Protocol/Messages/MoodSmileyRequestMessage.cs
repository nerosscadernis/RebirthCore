


















// Generated on 01/12/2017 03:52:55
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class MoodSmileyRequestMessage : NetworkMessage
{

public const uint Id = 6192;
public uint MessageId
{
    get { return Id; }
}

public uint smileyId;
        

public MoodSmileyRequestMessage()
{
}

public MoodSmileyRequestMessage(uint smileyId)
        {
            this.smileyId = smileyId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)smileyId);
            

}

public void Deserialize(IDataReader reader)
{

smileyId = reader.ReadVarUhShort();
            if (smileyId < 0)
                throw new System.Exception("Forbidden value on smileyId = " + smileyId + ", it doesn't respect the following condition : smileyId < 0");
            

}


}


}