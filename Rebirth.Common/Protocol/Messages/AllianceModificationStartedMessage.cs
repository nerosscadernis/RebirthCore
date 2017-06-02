


















// Generated on 01/12/2017 03:52:53
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class AllianceModificationStartedMessage : NetworkMessage
{

public const uint Id = 6444;
public uint MessageId
{
    get { return Id; }
}

public bool canChangeName;
        public bool canChangeTag;
        public bool canChangeEmblem;
        

public AllianceModificationStartedMessage()
{
}

public AllianceModificationStartedMessage(bool canChangeName, bool canChangeTag, bool canChangeEmblem)
        {
            this.canChangeName = canChangeName;
            this.canChangeTag = canChangeTag;
            this.canChangeEmblem = canChangeEmblem;
        }
        

public void Serialize(IDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, canChangeName);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, canChangeTag);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 2, canChangeEmblem);
            writer.WriteByte(flag1);
            

}

public void Deserialize(IDataReader reader)
{

byte flag1 = reader.ReadByte();
            canChangeName = BooleanByteWrapper.GetFlag(flag1, 0);
            canChangeTag = BooleanByteWrapper.GetFlag(flag1, 1);
            canChangeEmblem = BooleanByteWrapper.GetFlag(flag1, 2);
            

}


}


}