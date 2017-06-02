


















// Generated on 01/12/2017 03:52:52
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class HelloConnectMessage : NetworkMessage
{

public const uint Id = 3;
public uint MessageId
{
    get { return Id; }
}

public string salt;
        public sbyte[] key;
        

public HelloConnectMessage()
{
}

public HelloConnectMessage(string salt, sbyte[] key)
        {
            this.salt = salt;
            this.key = key;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(salt);
            writer.WriteVarInt((ushort)key.Length);
            foreach (var entry in key)
            {
                 writer.WriteSByte(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

salt = reader.ReadUTF();
            var limit = reader.ReadVarInt();
            key = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 key[i] = reader.ReadSByte();
            }
            

}


}


}