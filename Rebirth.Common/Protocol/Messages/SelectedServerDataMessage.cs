


















// Generated on 01/12/2017 03:52:52
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class SelectedServerDataMessage : NetworkMessage
{

public const uint Id = 42;
public uint MessageId
{
    get { return Id; }
}

public uint serverId;
        public string address;
        public ushort port;
        public bool canCreateNewCharacter;
        public sbyte[] ticket;
        

public SelectedServerDataMessage()
{
}

public SelectedServerDataMessage(uint serverId, string address, ushort port, bool canCreateNewCharacter, sbyte[] ticket)
        {
            this.serverId = serverId;
            this.address = address;
            this.port = port;
            this.canCreateNewCharacter = canCreateNewCharacter;
            this.ticket = ticket;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)serverId);
            writer.WriteUTF(address);
            writer.WriteShort((short)port);
            writer.WriteBoolean(canCreateNewCharacter);
            writer.WriteVarInt((ushort)ticket.Length);
            foreach (var entry in ticket)
            {
                 writer.WriteSByte(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

serverId = reader.ReadVarUhShort();
            if (serverId < 0)
                throw new System.Exception("Forbidden value on serverId = " + serverId + ", it doesn't respect the following condition : serverId < 0");
            address = reader.ReadUTF();
            port = reader.ReadUShort();
            if (port < 0 || port > 65535)
                throw new System.Exception("Forbidden value on port = " + port + ", it doesn't respect the following condition : port < 0 || port > 65535");
            canCreateNewCharacter = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            ticket = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 ticket[i] = reader.ReadSByte();
            }
            

}


}


}