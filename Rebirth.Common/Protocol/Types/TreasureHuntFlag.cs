


















// Generated on 01/12/2017 03:53:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class TreasureHuntFlag : NetworkType
{

public const short Id = 473;
public virtual short TypeId
{
    get { return Id; }
}

public int mapId;
        public sbyte state;
        

public TreasureHuntFlag()
{
}

public TreasureHuntFlag(int mapId, sbyte state)
        {
            this.mapId = mapId;
            this.state = state;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(mapId);
            writer.WriteSByte(state);
            

}

public virtual void Deserialize(IDataReader reader)
{

mapId = reader.ReadInt();
            state = reader.ReadSByte();
            if (state < 0)
                throw new System.Exception("Forbidden value on state = " + state + ", it doesn't respect the following condition : state < 0");
            

}


}


}