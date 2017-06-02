


















// Generated on 01/12/2017 03:52:54
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class TextInformationMessage : NetworkMessage
{

public const uint Id = 780;
public uint MessageId
{
    get { return Id; }
}

public sbyte msgType;
        public uint msgId;
        public string[] parameters;
        

public TextInformationMessage()
{
}

public TextInformationMessage(sbyte msgType, uint msgId, string[] parameters)
        {
            this.msgType = msgType;
            this.msgId = msgId;
            this.parameters = parameters;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(msgType);
            writer.WriteVarShort((int)msgId);
            writer.WriteUShort((ushort)parameters.Length);
            foreach (var entry in parameters)
            {
                 writer.WriteUTF(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

msgType = reader.ReadSByte();
            if (msgType < 0)
                throw new System.Exception("Forbidden value on msgType = " + msgType + ", it doesn't respect the following condition : msgType < 0");
            msgId = reader.ReadVarUhShort();
            if (msgId < 0)
                throw new System.Exception("Forbidden value on msgId = " + msgId + ", it doesn't respect the following condition : msgId < 0");
            var limit = reader.ReadUShort();
            parameters = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 parameters[i] = reader.ReadUTF();
            }
            

}


}


}