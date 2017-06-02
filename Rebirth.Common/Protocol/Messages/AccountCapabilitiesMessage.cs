


















// Generated on 01/12/2017 03:52:53
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class AccountCapabilitiesMessage : NetworkMessage
{

public const uint Id = 6216;
public uint MessageId
{
    get { return Id; }
}

public bool tutorialAvailable;
        public bool canCreateNewCharacter;
        public int accountId;
        public uint breedsVisible;
        public uint breedsAvailable;
        public sbyte status;
        

public AccountCapabilitiesMessage()
{
}

public AccountCapabilitiesMessage(bool tutorialAvailable, bool canCreateNewCharacter, int accountId, uint breedsVisible, uint breedsAvailable, sbyte status)
        {
            this.tutorialAvailable = tutorialAvailable;
            this.canCreateNewCharacter = canCreateNewCharacter;
            this.accountId = accountId;
            this.breedsVisible = breedsVisible;
            this.breedsAvailable = breedsAvailable;
            this.status = status;
        }
        

public void Serialize(IDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, tutorialAvailable);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, canCreateNewCharacter);
            writer.WriteByte(flag1);
            writer.WriteInt(accountId);
            writer.WriteVarInt((int)breedsVisible);
            writer.WriteVarInt((int)breedsAvailable);
            writer.WriteSByte(status);
            

}

public void Deserialize(IDataReader reader)
{

byte flag1 = reader.ReadByte();
            tutorialAvailable = BooleanByteWrapper.GetFlag(flag1, 0);
            canCreateNewCharacter = BooleanByteWrapper.GetFlag(flag1, 1);
            accountId = reader.ReadInt();
            if (accountId < 0)
                throw new System.Exception("Forbidden value on accountId = " + accountId + ", it doesn't respect the following condition : accountId < 0");
            breedsVisible = reader.ReadVarUhInt();
            if (breedsVisible < 0)
                throw new System.Exception("Forbidden value on breedsVisible = " + breedsVisible + ", it doesn't respect the following condition : breedsVisible < 0");
            breedsAvailable = reader.ReadVarUhInt();
            if (breedsAvailable < 0)
                throw new System.Exception("Forbidden value on breedsAvailable = " + breedsAvailable + ", it doesn't respect the following condition : breedsAvailable < 0");
            status = reader.ReadSByte();
            

}


}


}