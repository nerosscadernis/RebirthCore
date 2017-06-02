


















// Generated on 01/12/2017 03:52:56
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class SlaveSwitchContextMessage : NetworkMessage
{

public const uint Id = 6214;
public uint MessageId
{
    get { return Id; }
}

public double masterId;
        public double slaveId;
        public Types.SpellItem[] slaveSpells;
        public Types.CharacterCharacteristicsInformations slaveStats;
        public Types.Shortcut[] shortcuts;
        

public SlaveSwitchContextMessage()
{
}

public SlaveSwitchContextMessage(double masterId, double slaveId, Types.SpellItem[] slaveSpells, Types.CharacterCharacteristicsInformations slaveStats, Types.Shortcut[] shortcuts)
        {
            this.masterId = masterId;
            this.slaveId = slaveId;
            this.slaveSpells = slaveSpells;
            this.slaveStats = slaveStats;
            this.shortcuts = shortcuts;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(masterId);
            writer.WriteDouble(slaveId);
            writer.WriteUShort((ushort)slaveSpells.Length);
            foreach (var entry in slaveSpells)
            {
                 entry.Serialize(writer);
            }
            slaveStats.Serialize(writer);
            writer.WriteUShort((ushort)shortcuts.Length);
            foreach (var entry in shortcuts)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

masterId = reader.ReadDouble();
            if (masterId < -9.007199254740992E15 || masterId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on masterId = " + masterId + ", it doesn't respect the following condition : masterId < -9.007199254740992E15 || masterId > 9.007199254740992E15");
            slaveId = reader.ReadDouble();
            if (slaveId < -9.007199254740992E15 || slaveId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on slaveId = " + slaveId + ", it doesn't respect the following condition : slaveId < -9.007199254740992E15 || slaveId > 9.007199254740992E15");
            var limit = reader.ReadUShort();
            slaveSpells = new Types.SpellItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 slaveSpells[i] = new Types.SpellItem();
                 slaveSpells[i].Deserialize(reader);
            }
            slaveStats = new Types.CharacterCharacteristicsInformations();
            slaveStats.Deserialize(reader);
            limit = reader.ReadUShort();
            shortcuts = new Types.Shortcut[limit];
            for (int i = 0; i < limit; i++)
            {
                 shortcuts[i] = ProtocolTypeManager.GetInstance<Types.Shortcut>(reader.ReadShort());
                 shortcuts[i].Deserialize(reader);
            }
            

}


}


}