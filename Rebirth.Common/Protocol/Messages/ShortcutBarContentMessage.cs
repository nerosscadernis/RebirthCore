


















// Generated on 01/12/2017 03:53:05
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ShortcutBarContentMessage : NetworkMessage
{

public const uint Id = 6231;
public uint MessageId
{
    get { return Id; }
}

public sbyte barType;
        public Types.Shortcut[] shortcuts;
        

public ShortcutBarContentMessage()
{
}

public ShortcutBarContentMessage(sbyte barType, Types.Shortcut[] shortcuts)
        {
            this.barType = barType;
            this.shortcuts = shortcuts;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(barType);
            writer.WriteUShort((ushort)shortcuts.Length);
            foreach (var entry in shortcuts)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

barType = reader.ReadSByte();
            if (barType < 0)
                throw new System.Exception("Forbidden value on barType = " + barType + ", it doesn't respect the following condition : barType < 0");
            var limit = reader.ReadUShort();
            shortcuts = new Types.Shortcut[limit];
            for (int i = 0; i < limit; i++)
            {
                 shortcuts[i] = ProtocolTypeManager.GetInstance<Types.Shortcut>(reader.ReadShort());
                 shortcuts[i].Deserialize(reader);
            }
            

}


}


}