


















// Generated on 01/12/2017 03:53:03
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeWeightMessage : NetworkMessage
{

public const uint Id = 5793;
public uint MessageId
{
    get { return Id; }
}

public uint currentWeight;
        public uint maxWeight;
        

public ExchangeWeightMessage()
{
}

public ExchangeWeightMessage(uint currentWeight, uint maxWeight)
        {
            this.currentWeight = currentWeight;
            this.maxWeight = maxWeight;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)currentWeight);
            writer.WriteVarInt((int)maxWeight);
            

}

public void Deserialize(IDataReader reader)
{

currentWeight = reader.ReadVarUhInt();
            if (currentWeight < 0)
                throw new System.Exception("Forbidden value on currentWeight = " + currentWeight + ", it doesn't respect the following condition : currentWeight < 0");
            maxWeight = reader.ReadVarUhInt();
            if (maxWeight < 0)
                throw new System.Exception("Forbidden value on maxWeight = " + maxWeight + ", it doesn't respect the following condition : maxWeight < 0");
            

}


}


}