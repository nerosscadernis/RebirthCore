


















// Generated on 01/12/2017 03:52:52
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;
using Rebirth.Common.Protocol.Enums;

namespace Rebirth.Common.Protocol.Messages
{

    public class UpdateStatuServerMessage : NetworkMessage
    {

        public const uint Id = 37;
        public uint MessageId
        {
            get { return Id; }
        }

        public ServerStatusEnum state;
        public int serverId;

        public UpdateStatuServerMessage()
        {
        }

        public UpdateStatuServerMessage(ServerStatusEnum state, int serverId)
        {
            this.state = state;
            this.serverId = serverId;
        }


        public void Serialize(IDataWriter writer)
        {
            writer.WriteByte((byte)state);
            writer.WriteInt(serverId);
        }

        public void Deserialize(IDataReader reader)
        {
            state = (ServerStatusEnum)reader.ReadByte();
            serverId = reader.ReadInt();
        }


    }


}