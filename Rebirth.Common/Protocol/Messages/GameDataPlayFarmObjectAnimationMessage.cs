


















// Generated on 01/12/2017 03:52:58
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameDataPlayFarmObjectAnimationMessage : NetworkMessage
{

public const uint Id = 6026;
public uint MessageId
{
    get { return Id; }
}

public uint[] cellId;
        

public GameDataPlayFarmObjectAnimationMessage()
{
}

public GameDataPlayFarmObjectAnimationMessage(uint[] cellId)
        {
            this.cellId = cellId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)cellId.Length);
            foreach (var entry in cellId)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            cellId = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 cellId[i] = reader.ReadVarUhShort();
            }
            

}


}


}