


















// Generated on 01/12/2017 03:53:02
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ExchangeCraftResultMagicWithObjectDescMessage : ExchangeCraftResultWithObjectDescMessage
{

public const uint Id = 6188;
public uint MessageId
{
    get { return Id; }
}

public sbyte magicPoolStatus;
        

public ExchangeCraftResultMagicWithObjectDescMessage()
{
}

public ExchangeCraftResultMagicWithObjectDescMessage(sbyte craftResult, Types.ObjectItemNotInContainer objectInfo, sbyte magicPoolStatus)
         : base(craftResult, objectInfo)
        {
            this.magicPoolStatus = magicPoolStatus;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(magicPoolStatus);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            magicPoolStatus = reader.ReadSByte();
            

}


}


}