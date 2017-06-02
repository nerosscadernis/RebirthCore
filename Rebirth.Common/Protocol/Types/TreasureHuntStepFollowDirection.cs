


















// Generated on 01/12/2017 03:53:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class TreasureHuntStepFollowDirection : TreasureHuntStep
{

public const short Id = 468;
public override short TypeId
{
    get { return Id; }
}

public sbyte direction;
        public uint mapCount;
        

public TreasureHuntStepFollowDirection()
{
}

public TreasureHuntStepFollowDirection(sbyte direction, uint mapCount)
        {
            this.direction = direction;
            this.mapCount = mapCount;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(direction);
            writer.WriteVarShort((int)mapCount);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            direction = reader.ReadSByte();
            if (direction < 0)
                throw new System.Exception("Forbidden value on direction = " + direction + ", it doesn't respect the following condition : direction < 0");
            mapCount = reader.ReadVarUhShort();
            if (mapCount < 0)
                throw new System.Exception("Forbidden value on mapCount = " + mapCount + ", it doesn't respect the following condition : mapCount < 0");
            

}


}


}