


















// Generated on 01/12/2017 03:52:55
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class DungeonKeyRingMessage : NetworkMessage
{

public const uint Id = 6299;
public uint MessageId
{
    get { return Id; }
}

public uint[] availables;
        public uint[] unavailables;
        

public DungeonKeyRingMessage()
{
}

public DungeonKeyRingMessage(uint[] availables, uint[] unavailables)
        {
            this.availables = availables;
            this.unavailables = unavailables;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)availables.Length);
            foreach (var entry in availables)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteUShort((ushort)unavailables.Length);
            foreach (var entry in unavailables)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            availables = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 availables[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            unavailables = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 unavailables[i] = reader.ReadVarUhShort();
            }
            

}


}


}