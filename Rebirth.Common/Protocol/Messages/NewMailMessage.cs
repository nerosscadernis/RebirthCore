


















// Generated on 01/12/2017 03:53:05
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class NewMailMessage : MailStatusMessage
{

public const uint Id = 6292;
public uint MessageId
{
    get { return Id; }
}

public int[] sendersAccountId;
        

public NewMailMessage()
{
}

public NewMailMessage(uint unread, uint total, int[] sendersAccountId)
         : base(unread, total)
        {
            this.sendersAccountId = sendersAccountId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)sendersAccountId.Length);
            foreach (var entry in sendersAccountId)
            {
                 writer.WriteInt(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            sendersAccountId = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 sendersAccountId[i] = reader.ReadInt();
            }
            

}


}


}