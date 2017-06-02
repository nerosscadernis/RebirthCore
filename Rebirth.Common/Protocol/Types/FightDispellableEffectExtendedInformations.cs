


















// Generated on 01/12/2017 03:53:06
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class FightDispellableEffectExtendedInformations : NetworkType
{

public const short Id = 208;
public virtual short TypeId
{
    get { return Id; }
}

public uint actionId;
        public double sourceId;
        public Types.AbstractFightDispellableEffect effect;
        

public FightDispellableEffectExtendedInformations()
{
}

public FightDispellableEffectExtendedInformations(uint actionId, double sourceId, Types.AbstractFightDispellableEffect effect)
        {
            this.actionId = actionId;
            this.sourceId = sourceId;
            this.effect = effect;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)actionId);
            writer.WriteDouble(sourceId);
            writer.WriteShort(effect.TypeId);
            effect.Serialize(writer);
            

}

public virtual void Deserialize(IDataReader reader)
{

actionId = reader.ReadVarUhShort();
            if (actionId < 0)
                throw new System.Exception("Forbidden value on actionId = " + actionId + ", it doesn't respect the following condition : actionId < 0");
            sourceId = reader.ReadDouble();
            if (sourceId < -9.007199254740992E15 || sourceId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on sourceId = " + sourceId + ", it doesn't respect the following condition : sourceId < -9.007199254740992E15 || sourceId > 9.007199254740992E15");
            effect = ProtocolTypeManager.GetInstance<Types.AbstractFightDispellableEffect>(reader.ReadShort());
            effect.Deserialize(reader);
            

}


}


}