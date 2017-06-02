


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class AccountHouseMessage : NetworkMessage
{

public const uint Id = 6315;
public uint MessageId
{
    get { return Id; }
}

public Types.AccountHouseInformations[] houses;
        

public AccountHouseMessage()
{
}

public AccountHouseMessage(Types.AccountHouseInformations[] houses)
        {
            this.houses = houses;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)houses.Length);
            foreach (var entry in houses)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            houses = new Types.AccountHouseInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 houses[i] = new Types.AccountHouseInformations();
                 houses[i].Deserialize(reader);
            }
            

}


}


}