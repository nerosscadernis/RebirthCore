


















// Generated on 01/12/2017 03:52:52
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionAcknowledgementMessage : NetworkMessage
{

public const uint Id = 957;
public uint MessageId
{
    get { return Id; }
}

public bool valid;
        public sbyte actionId;
        

public GameActionAcknowledgementMessage()
{
}

public GameActionAcknowledgementMessage(bool valid, sbyte actionId)
        {
            this.valid = valid;
            this.actionId = actionId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(valid);
            writer.WriteSByte(actionId);
            

}

public void Deserialize(IDataReader reader)
{

valid = reader.ReadBoolean();
            actionId = reader.ReadSByte();
            

}


}


}