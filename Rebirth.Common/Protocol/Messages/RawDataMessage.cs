


















// Generated on 07/24/2016 18:36:04
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

    public class RawDataMessage : NetworkMessage
    {

        public const uint Id = 6253;
        public uint MessageId
        {
            get { return Id; }
        }

        public byte[] Content;



        public RawDataMessage(byte[] content)
        {
            Content = content;
        }


        public RawDataMessage()
        {

        }



        public void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt(Content.Length);
            writer.WriteBytes(Content);
        }

        public void Deserialize(IDataReader reader)
        {
            Content = reader.ReadBytes(reader.ReadVarInt());
        }


    }


}