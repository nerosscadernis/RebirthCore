


















// Generated on 01/12/2017 03:52:54
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ReloginTokenStatusMessage : NetworkMessage
{

public const uint Id = 6539;
public uint MessageId
{
    get { return Id; }
}

public bool validToken;
        public sbyte[] ticket;
        

public ReloginTokenStatusMessage()
{
}

public ReloginTokenStatusMessage(bool validToken, sbyte[] ticket)
        {
            this.validToken = validToken;
            this.ticket = ticket;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(validToken);
            writer.WriteUShort((ushort)ticket.Length);
            foreach (var entry in ticket)
            {
                 writer.WriteSByte(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

validToken = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            ticket = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 ticket[i] = reader.ReadSByte();
            }
            

}


}


}