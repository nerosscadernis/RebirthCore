


















// Generated on 01/12/2017 03:53:04
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class SymbioticObjectErrorMessage : ObjectErrorMessage
{

public const uint Id = 6526;
public uint MessageId
{
    get { return Id; }
}

public sbyte errorCode;
        

public SymbioticObjectErrorMessage()
{
}

public SymbioticObjectErrorMessage(sbyte reason, sbyte errorCode)
         : base(reason)
        {
            this.errorCode = errorCode;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(errorCode);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            errorCode = reader.ReadSByte();
            

}


}


}