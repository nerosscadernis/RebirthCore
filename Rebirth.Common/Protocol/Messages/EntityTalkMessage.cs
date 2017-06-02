


















// Generated on 01/12/2017 03:52:58
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class EntityTalkMessage : NetworkMessage
{

public const uint Id = 6110;
public uint MessageId
{
    get { return Id; }
}

public double entityId;
        public uint textId;
        public string[] parameters;
        

public EntityTalkMessage()
{
}

public EntityTalkMessage(double entityId, uint textId, string[] parameters)
        {
            this.entityId = entityId;
            this.textId = textId;
            this.parameters = parameters;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(entityId);
            writer.WriteVarShort((int)textId);
            writer.WriteUShort((ushort)parameters.Length);
            foreach (var entry in parameters)
            {
                 writer.WriteUTF(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

entityId = reader.ReadDouble();
            if (entityId < -9.007199254740992E15 || entityId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on entityId = " + entityId + ", it doesn't respect the following condition : entityId < -9.007199254740992E15 || entityId > 9.007199254740992E15");
            textId = reader.ReadVarUhShort();
            if (textId < 0)
                throw new System.Exception("Forbidden value on textId = " + textId + ", it doesn't respect the following condition : textId < 0");
            var limit = reader.ReadUShort();
            parameters = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 parameters[i] = reader.ReadUTF();
            }
            

}


}


}