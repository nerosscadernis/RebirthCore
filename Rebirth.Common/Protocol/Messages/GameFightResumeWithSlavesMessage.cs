


















// Generated on 01/12/2017 03:52:55
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameFightResumeWithSlavesMessage : GameFightResumeMessage
{

public const uint Id = 6215;
public uint MessageId
{
    get { return Id; }
}

public Types.GameFightResumeSlaveInfo[] slavesInfo;
        

public GameFightResumeWithSlavesMessage()
{
}

public GameFightResumeWithSlavesMessage(Types.FightDispellableEffectExtendedInformations[] effects, Types.GameActionMark[] marks, uint gameTurn, int fightStart, Types.Idol[] idols, Types.GameFightSpellCooldown[] spellCooldowns, sbyte summonCount, sbyte bombCount, Types.GameFightResumeSlaveInfo[] slavesInfo)
         : base(effects, marks, gameTurn, fightStart, idols, spellCooldowns, summonCount, bombCount)
        {
            this.slavesInfo = slavesInfo;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)slavesInfo.Length);
            foreach (var entry in slavesInfo)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            slavesInfo = new Types.GameFightResumeSlaveInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 slavesInfo[i] = new Types.GameFightResumeSlaveInfo();
                 slavesInfo[i].Deserialize(reader);
            }
            

}


}


}