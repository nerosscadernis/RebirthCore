


















// Generated on 01/12/2017 03:53:00
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class DareWonListMessage : NetworkMessage
{

public const uint Id = 6682;
public uint MessageId
{
    get { return Id; }
}

public double[] dareId;
        

public DareWonListMessage()
{
}

public DareWonListMessage(double[] dareId)
        {
            this.dareId = dareId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)dareId.Length);
            foreach (var entry in dareId)
            {
                 writer.WriteDouble(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            dareId = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 dareId[i] = reader.ReadDouble();
            }
            

}


}


}