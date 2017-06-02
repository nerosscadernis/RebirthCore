


















// Generated on 01/12/2017 03:52:54
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

    public class CharacterCreationRequestMessage : NetworkMessage
    {

        public const uint Id = 160;
        public uint MessageId
        {
            get { return Id; }
        }

        public string name;
        public sbyte breed;
        public bool sex;
        public int[] colors;
        public uint cosmeticId;


        public CharacterCreationRequestMessage()
        {
        }

        public CharacterCreationRequestMessage(string name, sbyte breed, bool sex, int[] colors, uint cosmeticId)
        {
            this.name = name;
            this.breed = breed;
            this.sex = sex;
            this.colors = colors;
            this.cosmeticId = cosmeticId;
        }


        public void Serialize(IDataWriter writer)
        {

            writer.WriteUTF(name);
            writer.WriteSByte(breed);
            writer.WriteBoolean(sex);
            writer.WriteUShort((ushort)colors.Length);
            foreach (var entry in colors)
            {
                writer.WriteInt(entry);
            }
            writer.WriteVarShort((int)cosmeticId);


        }

        public void Deserialize(IDataReader reader)
        {
            colors = new int[5];
            name = reader.ReadUTF();
            breed = reader.ReadSByte();
            sex = reader.ReadBoolean();
            for (int i = 0; i < 5; i++)
            {
                colors[i] = reader.ReadInt();
            }
            cosmeticId = reader.ReadVarUhShort();
            if (cosmeticId < 0)
                throw new System.Exception("Forbidden value on cosmeticId = " + cosmeticId + ", it doesn't respect the following condition : cosmeticId < 0");


        }


    }


}