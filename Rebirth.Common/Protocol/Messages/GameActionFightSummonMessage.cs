


















// Generated on 01/12/2017 03:52:53
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionFightSummonMessage : AbstractGameActionMessage
{

public const uint Id = 5825;
public uint MessageId
{
    get { return Id; }
}

public Types.GameFightFighterInformations[] summons;
        

public GameActionFightSummonMessage()
{
}

public GameActionFightSummonMessage(uint actionId, double sourceId, Types.GameFightFighterInformations[] summons)
         : base(actionId, sourceId)
        {
            this.summons = summons;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)summons.Length);
            foreach (var entry in summons)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            summons = new Types.GameFightFighterInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 summons[i] = ProtocolTypeManager.GetInstance<Types.GameFightFighterInformations>(reader.ReadShort());
                 summons[i].Deserialize(reader);
            }
            

}


}


}