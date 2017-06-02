using Rebirth.Common.Network;
using System;
using System.Collections.Generic;
using System.Text;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{
    public class AccountInformationsMessage : NetworkMessage
    {
        public const uint Id = 36;

        public uint MessageId
        { get { return Id; } }

        public int AccId = 0;
        public string Key = "";
        public string Nickname = "";
        public CharacterRoleEnum Role = CharacterRoleEnum.Player;
        public string SecretQuestion = "";
        public string SecretAnswer = "";

        public void Deserialize(IDataReader reader)
        {
            AccId = reader.ReadInt();
            Key = reader.ReadUTF();
            Nickname = reader.ReadUTF();
            Role = (CharacterRoleEnum)reader.ReadByte();
            SecretQuestion = reader.ReadUTF();
            SecretAnswer = reader.ReadUTF();
        }

        public void Serialize(IDataWriter writer)
        {
            writer.WriteInt(AccId);
            writer.WriteUTF(Key);
            writer.WriteUTF(Nickname);
            writer.WriteByte((byte)Role);
            writer.WriteUTF(SecretQuestion);
            writer.WriteUTF(SecretAnswer);
        }
    }
}
