


















// Generated on 01/12/2017 03:53:00
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class DareInformationsMessage : NetworkMessage
{

public const uint Id = 6656;
public uint MessageId
{
    get { return Id; }
}

public Types.DareInformations dareFixedInfos;
        public Types.DareVersatileInformations dareVersatilesInfos;
        

public DareInformationsMessage()
{
}

public DareInformationsMessage(Types.DareInformations dareFixedInfos, Types.DareVersatileInformations dareVersatilesInfos)
        {
            this.dareFixedInfos = dareFixedInfos;
            this.dareVersatilesInfos = dareVersatilesInfos;
        }
        

public void Serialize(IDataWriter writer)
{

dareFixedInfos.Serialize(writer);
            dareVersatilesInfos.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

dareFixedInfos = new Types.DareInformations();
            dareFixedInfos.Deserialize(reader);
            dareVersatilesInfos = new Types.DareVersatileInformations();
            dareVersatilesInfos.Deserialize(reader);
            

}


}


}