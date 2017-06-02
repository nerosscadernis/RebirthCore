


















// Generated on 01/12/2017 03:53:05
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class PrismsInfoValidMessage : NetworkMessage
{

public const uint Id = 6451;
public uint MessageId
{
    get { return Id; }
}

public Types.PrismFightersInformation[] fights;
        

public PrismsInfoValidMessage()
{
}

public PrismsInfoValidMessage(Types.PrismFightersInformation[] fights)
        {
            this.fights = fights;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)fights.Length);
            foreach (var entry in fights)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            fights = new Types.PrismFightersInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 fights[i] = new Types.PrismFightersInformation();
                 fights[i].Deserialize(reader);
            }
            

}


}


}