


















// Generated on 01/12/2017 03:52:53
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class AlmanachCalendarDateMessage : NetworkMessage
{

public const uint Id = 6341;
public uint MessageId
{
    get { return Id; }
}

public int date;
        

public AlmanachCalendarDateMessage()
{
}

public AlmanachCalendarDateMessage(int date)
        {
            this.date = date;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(date);
            

}

public void Deserialize(IDataReader reader)
{

date = reader.ReadInt();
            

}


}


}