using System;
using System.Collections.Generic;
using System.Text;
using Rebirth.Common.IO;
using Rebirth.Common.Network;

namespace Rebirth.Common.Protocol.Messages
{
    public class DeleteCharacterMessage : NetworkMessage
    {
        public const uint Id = 34;
        public uint MessageId
        {
            get { return Id; }
        }

        public int AccountId = 0;

        public DeleteCharacterMessage() { }

        public DeleteCharacterMessage(int accountId)
        {
            AccountId = accountId;
        }

        public void Deserialize(IDataReader reader)
        {
            AccountId = reader.ReadInt();
        }

        public void Serialize(IDataWriter writer)
        {
            writer.WriteInt(AccountId);
        }
    }
}
