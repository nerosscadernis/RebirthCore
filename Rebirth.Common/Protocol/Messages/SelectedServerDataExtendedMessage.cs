


















// Generated on 01/12/2017 03:52:52
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class SelectedServerDataExtendedMessage : SelectedServerDataMessage
{

public const uint Id = 6469;
public uint MessageId
{
    get { return Id; }
}

public uint[] serverIds;
        

public SelectedServerDataExtendedMessage()
{
}

public SelectedServerDataExtendedMessage(uint serverId, string address, ushort port, bool canCreateNewCharacter, sbyte[] ticket, uint[] serverIds)
         : base(serverId, address, port, canCreateNewCharacter, ticket)
        {
            this.serverIds = serverIds;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)serverIds.Length);
            foreach (var entry in serverIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            serverIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 serverIds[i] = reader.ReadVarUhShort();
            }
            

}


}


}