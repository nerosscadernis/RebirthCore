


















// Generated on 01/12/2017 03:53:09
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class AbstractContactInformations : NetworkType
{

public const short Id = 380;
public virtual short TypeId
{
    get { return Id; }
}

public int accountId;
        public string accountName;
        

public AbstractContactInformations()
{
}

public AbstractContactInformations(int accountId, string accountName)
        {
            this.accountId = accountId;
            this.accountName = accountName;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(accountId);
            writer.WriteUTF(accountName);
            

}

public virtual void Deserialize(IDataReader reader)
{

accountId = reader.ReadInt();
            if (accountId < 0)
                throw new System.Exception("Forbidden value on accountId = " + accountId + ", it doesn't respect the following condition : accountId < 0");
            accountName = reader.ReadUTF();
            

}


}


}