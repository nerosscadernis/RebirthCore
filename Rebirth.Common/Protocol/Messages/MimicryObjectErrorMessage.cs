


















// Generated on 01/12/2017 03:53:03
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class MimicryObjectErrorMessage : SymbioticObjectErrorMessage
{

public const uint Id = 6461;
public uint MessageId
{
    get { return Id; }
}

public bool preview;
        

public MimicryObjectErrorMessage()
{
}

public MimicryObjectErrorMessage(sbyte reason, sbyte errorCode, bool preview)
         : base(reason, errorCode)
        {
            this.preview = preview;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(preview);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            preview = reader.ReadBoolean();
            

}


}


}