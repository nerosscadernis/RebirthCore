


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class IdolSelectErrorMessage : NetworkMessage
{

public const uint Id = 6584;
public uint MessageId
{
    get { return Id; }
}

public bool activate;
        public bool party;
        public sbyte reason;
        public uint idolId;
        

public IdolSelectErrorMessage()
{
}

public IdolSelectErrorMessage(bool activate, bool party, sbyte reason, uint idolId)
        {
            this.activate = activate;
            this.party = party;
            this.reason = reason;
            this.idolId = idolId;
        }
        

public void Serialize(IDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, activate);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, party);
            writer.WriteByte(flag1);
            writer.WriteSByte(reason);
            writer.WriteVarShort((int)idolId);
            

}

public void Deserialize(IDataReader reader)
{

byte flag1 = reader.ReadByte();
            activate = BooleanByteWrapper.GetFlag(flag1, 0);
            party = BooleanByteWrapper.GetFlag(flag1, 1);
            reason = reader.ReadSByte();
            if (reason < 0)
                throw new System.Exception("Forbidden value on reason = " + reason + ", it doesn't respect the following condition : reason < 0");
            idolId = reader.ReadVarUhShort();
            if (idolId < 0)
                throw new System.Exception("Forbidden value on idolId = " + idolId + ", it doesn't respect the following condition : idolId < 0");
            

}


}


}