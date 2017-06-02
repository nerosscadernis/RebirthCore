


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class TaxCollectorStateUpdateMessage : NetworkMessage
{

public const uint Id = 6455;
public uint MessageId
{
    get { return Id; }
}

public int uniqueId;
        public sbyte state;
        

public TaxCollectorStateUpdateMessage()
{
}

public TaxCollectorStateUpdateMessage(int uniqueId, sbyte state)
        {
            this.uniqueId = uniqueId;
            this.state = state;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(uniqueId);
            writer.WriteSByte(state);
            

}

public void Deserialize(IDataReader reader)
{

uniqueId = reader.ReadInt();
            state = reader.ReadSByte();
            

}


}


}