using Rebirth.Common.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.Common.Network
{
    public class GetAccountRequestMessage : NetworkMessage
    {
        public const uint Id = 38;
        public uint MessageId
        {
            get { return Id; }
        }

        public string Key = "";

        public GetAccountRequestMessage() { }

        public GetAccountRequestMessage(string key)
        {
            Key = key;
        }

        public void Deserialize(IDataReader reader)
        {
            Key = reader.ReadUTF();
        }

        public void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(Key);
        }
    }
}
