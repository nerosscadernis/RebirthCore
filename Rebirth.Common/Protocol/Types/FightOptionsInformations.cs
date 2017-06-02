


















// Generated on 01/12/2017 03:53:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class FightOptionsInformations : NetworkType
{

public const short Id = 20;
public virtual short TypeId
{
    get { return Id; }
}

public bool isSecret;
        public bool isRestrictedToPartyOnly;
        public bool isClosed;
        public bool isAskingForHelp;
        

public FightOptionsInformations()
{
}

public FightOptionsInformations(bool isSecret, bool isRestrictedToPartyOnly, bool isClosed, bool isAskingForHelp)
        {
            this.isSecret = isSecret;
            this.isRestrictedToPartyOnly = isRestrictedToPartyOnly;
            this.isClosed = isClosed;
            this.isAskingForHelp = isAskingForHelp;
        }
        

public virtual void Serialize(IDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, isSecret);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, isRestrictedToPartyOnly);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 2, isClosed);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 3, isAskingForHelp);
            writer.WriteByte(flag1);
            

}

public virtual void Deserialize(IDataReader reader)
{

byte flag1 = reader.ReadByte();
            isSecret = BooleanByteWrapper.GetFlag(flag1, 0);
            isRestrictedToPartyOnly = BooleanByteWrapper.GetFlag(flag1, 1);
            isClosed = BooleanByteWrapper.GetFlag(flag1, 2);
            isAskingForHelp = BooleanByteWrapper.GetFlag(flag1, 3);
            

}


}


}