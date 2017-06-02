


















// Generated on 01/12/2017 03:53:05
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class StartupActionsListMessage : NetworkMessage
{

public const uint Id = 1301;
public uint MessageId
{
    get { return Id; }
}

public Types.StartupActionAddObject[] actions;
        

public StartupActionsListMessage()
{
}

public StartupActionsListMessage(Types.StartupActionAddObject[] actions)
        {
            this.actions = actions;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)actions.Length);
            foreach (var entry in actions)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            actions = new Types.StartupActionAddObject[limit];
            for (int i = 0; i < limit; i++)
            {
                 actions[i] = new Types.StartupActionAddObject();
                 actions[i].Deserialize(reader);
            }
            

}


}


}