


















// Generated on 01/12/2017 03:52:54
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class BasicWhoIsRequestMessage : NetworkMessage
{

public const uint Id = 181;
public uint MessageId
{
    get { return Id; }
}

public bool verbose;
        public string search;
        

public BasicWhoIsRequestMessage()
{
}

public BasicWhoIsRequestMessage(bool verbose, string search)
        {
            this.verbose = verbose;
            this.search = search;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(verbose);
            writer.WriteUTF(search);
            

}

public void Deserialize(IDataReader reader)
{

verbose = reader.ReadBoolean();
            search = reader.ReadUTF();
            

}


}


}