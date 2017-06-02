


















// Generated on 01/12/2017 03:53:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameFightMinimalStats : NetworkType
{

public const short Id = 31;
public virtual short TypeId
{
    get { return Id; }
}

public uint lifePoints;
        public uint maxLifePoints;
        public uint baseMaxLifePoints;
        public uint permanentDamagePercent;
        public uint shieldPoints;
        public int actionPoints;
        public int maxActionPoints;
        public int movementPoints;
        public int maxMovementPoints;
        public double summoner;
        public bool summoned;
        public int neutralElementResistPercent;
        public int earthElementResistPercent;
        public int waterElementResistPercent;
        public int airElementResistPercent;
        public int fireElementResistPercent;
        public int neutralElementReduction;
        public int earthElementReduction;
        public int waterElementReduction;
        public int airElementReduction;
        public int fireElementReduction;
        public int criticalDamageFixedResist;
        public int pushDamageFixedResist;
        public int pvpNeutralElementResistPercent;
        public int pvpEarthElementResistPercent;
        public int pvpWaterElementResistPercent;
        public int pvpAirElementResistPercent;
        public int pvpFireElementResistPercent;
        public int pvpNeutralElementReduction;
        public int pvpEarthElementReduction;
        public int pvpWaterElementReduction;
        public int pvpAirElementReduction;
        public int pvpFireElementReduction;
        public uint dodgePALostProbability;
        public uint dodgePMLostProbability;
        public int tackleBlock;
        public int tackleEvade;
        public int fixedDamageReflection;
        public sbyte invisibilityState;
        

public GameFightMinimalStats()
{
}

public GameFightMinimalStats(uint lifePoints, uint maxLifePoints, uint baseMaxLifePoints, uint permanentDamagePercent, uint shieldPoints, int actionPoints, int maxActionPoints, int movementPoints, int maxMovementPoints, double summoner, bool summoned, int neutralElementResistPercent, int earthElementResistPercent, int waterElementResistPercent, int airElementResistPercent, int fireElementResistPercent, int neutralElementReduction, int earthElementReduction, int waterElementReduction, int airElementReduction, int fireElementReduction, int criticalDamageFixedResist, int pushDamageFixedResist, int pvpNeutralElementResistPercent, int pvpEarthElementResistPercent, int pvpWaterElementResistPercent, int pvpAirElementResistPercent, int pvpFireElementResistPercent, int pvpNeutralElementReduction, int pvpEarthElementReduction, int pvpWaterElementReduction, int pvpAirElementReduction, int pvpFireElementReduction, uint dodgePALostProbability, uint dodgePMLostProbability, int tackleBlock, int tackleEvade, int fixedDamageReflection, sbyte invisibilityState)
        {
            this.lifePoints = lifePoints;
            this.maxLifePoints = maxLifePoints;
            this.baseMaxLifePoints = baseMaxLifePoints;
            this.permanentDamagePercent = permanentDamagePercent;
            this.shieldPoints = shieldPoints;
            this.actionPoints = actionPoints;
            this.maxActionPoints = maxActionPoints;
            this.movementPoints = movementPoints;
            this.maxMovementPoints = maxMovementPoints;
            this.summoner = summoner;
            this.summoned = summoned;
            this.neutralElementResistPercent = neutralElementResistPercent;
            this.earthElementResistPercent = earthElementResistPercent;
            this.waterElementResistPercent = waterElementResistPercent;
            this.airElementResistPercent = airElementResistPercent;
            this.fireElementResistPercent = fireElementResistPercent;
            this.neutralElementReduction = neutralElementReduction;
            this.earthElementReduction = earthElementReduction;
            this.waterElementReduction = waterElementReduction;
            this.airElementReduction = airElementReduction;
            this.fireElementReduction = fireElementReduction;
            this.criticalDamageFixedResist = criticalDamageFixedResist;
            this.pushDamageFixedResist = pushDamageFixedResist;
            this.pvpNeutralElementResistPercent = pvpNeutralElementResistPercent;
            this.pvpEarthElementResistPercent = pvpEarthElementResistPercent;
            this.pvpWaterElementResistPercent = pvpWaterElementResistPercent;
            this.pvpAirElementResistPercent = pvpAirElementResistPercent;
            this.pvpFireElementResistPercent = pvpFireElementResistPercent;
            this.pvpNeutralElementReduction = pvpNeutralElementReduction;
            this.pvpEarthElementReduction = pvpEarthElementReduction;
            this.pvpWaterElementReduction = pvpWaterElementReduction;
            this.pvpAirElementReduction = pvpAirElementReduction;
            this.pvpFireElementReduction = pvpFireElementReduction;
            this.dodgePALostProbability = dodgePALostProbability;
            this.dodgePMLostProbability = dodgePMLostProbability;
            this.tackleBlock = tackleBlock;
            this.tackleEvade = tackleEvade;
            this.fixedDamageReflection = fixedDamageReflection;
            this.invisibilityState = invisibilityState;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)lifePoints);
            writer.WriteVarInt((int)maxLifePoints);
            writer.WriteVarInt((int)baseMaxLifePoints);
            writer.WriteVarInt((int)permanentDamagePercent);
            writer.WriteVarInt((int)shieldPoints);
            writer.WriteVarShort((int)actionPoints);
            writer.WriteVarShort((int)maxActionPoints);
            writer.WriteVarShort((int)movementPoints);
            writer.WriteVarShort((int)maxMovementPoints);
            writer.WriteDouble(summoner);
            writer.WriteBoolean(summoned);
            writer.WriteVarShort((int)neutralElementResistPercent);
            writer.WriteVarShort((int)earthElementResistPercent);
            writer.WriteVarShort((int)waterElementResistPercent);
            writer.WriteVarShort((int)airElementResistPercent);
            writer.WriteVarShort((int)fireElementResistPercent);
            writer.WriteVarShort((int)neutralElementReduction);
            writer.WriteVarShort((int)earthElementReduction);
            writer.WriteVarShort((int)waterElementReduction);
            writer.WriteVarShort((int)airElementReduction);
            writer.WriteVarShort((int)fireElementReduction);
            writer.WriteVarShort((int)criticalDamageFixedResist);
            writer.WriteVarShort((int)pushDamageFixedResist);
            writer.WriteVarShort((int)pvpNeutralElementResistPercent);
            writer.WriteVarShort((int)pvpEarthElementResistPercent);
            writer.WriteVarShort((int)pvpWaterElementResistPercent);
            writer.WriteVarShort((int)pvpAirElementResistPercent);
            writer.WriteVarShort((int)pvpFireElementResistPercent);
            writer.WriteVarShort((int)pvpNeutralElementReduction);
            writer.WriteVarShort((int)pvpEarthElementReduction);
            writer.WriteVarShort((int)pvpWaterElementReduction);
            writer.WriteVarShort((int)pvpAirElementReduction);
            writer.WriteVarShort((int)pvpFireElementReduction);
            writer.WriteVarShort((int)dodgePALostProbability);
            writer.WriteVarShort((int)dodgePMLostProbability);
            writer.WriteVarShort((int)tackleBlock);
            writer.WriteVarShort((int)tackleEvade);
            writer.WriteVarShort((int)fixedDamageReflection);
            writer.WriteSByte(invisibilityState);
            

}

public virtual void Deserialize(IDataReader reader)
{

lifePoints = reader.ReadVarUhInt();
            if (lifePoints < 0)
                throw new System.Exception("Forbidden value on lifePoints = " + lifePoints + ", it doesn't respect the following condition : lifePoints < 0");
            maxLifePoints = reader.ReadVarUhInt();
            if (maxLifePoints < 0)
                throw new System.Exception("Forbidden value on maxLifePoints = " + maxLifePoints + ", it doesn't respect the following condition : maxLifePoints < 0");
            baseMaxLifePoints = reader.ReadVarUhInt();
            if (baseMaxLifePoints < 0)
                throw new System.Exception("Forbidden value on baseMaxLifePoints = " + baseMaxLifePoints + ", it doesn't respect the following condition : baseMaxLifePoints < 0");
            permanentDamagePercent = reader.ReadVarUhInt();
            if (permanentDamagePercent < 0)
                throw new System.Exception("Forbidden value on permanentDamagePercent = " + permanentDamagePercent + ", it doesn't respect the following condition : permanentDamagePercent < 0");
            shieldPoints = reader.ReadVarUhInt();
            if (shieldPoints < 0)
                throw new System.Exception("Forbidden value on shieldPoints = " + shieldPoints + ", it doesn't respect the following condition : shieldPoints < 0");
            actionPoints = reader.ReadVarShort();
            maxActionPoints = reader.ReadVarShort();
            movementPoints = reader.ReadVarShort();
            maxMovementPoints = reader.ReadVarShort();
            summoner = reader.ReadDouble();
            if (summoner < -9.007199254740992E15 || summoner > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on summoner = " + summoner + ", it doesn't respect the following condition : summoner < -9.007199254740992E15 || summoner > 9.007199254740992E15");
            summoned = reader.ReadBoolean();
            neutralElementResistPercent = reader.ReadVarShort();
            earthElementResistPercent = reader.ReadVarShort();
            waterElementResistPercent = reader.ReadVarShort();
            airElementResistPercent = reader.ReadVarShort();
            fireElementResistPercent = reader.ReadVarShort();
            neutralElementReduction = reader.ReadVarShort();
            earthElementReduction = reader.ReadVarShort();
            waterElementReduction = reader.ReadVarShort();
            airElementReduction = reader.ReadVarShort();
            fireElementReduction = reader.ReadVarShort();
            criticalDamageFixedResist = reader.ReadVarShort();
            pushDamageFixedResist = reader.ReadVarShort();
            pvpNeutralElementResistPercent = reader.ReadVarShort();
            pvpEarthElementResistPercent = reader.ReadVarShort();
            pvpWaterElementResistPercent = reader.ReadVarShort();
            pvpAirElementResistPercent = reader.ReadVarShort();
            pvpFireElementResistPercent = reader.ReadVarShort();
            pvpNeutralElementReduction = reader.ReadVarShort();
            pvpEarthElementReduction = reader.ReadVarShort();
            pvpWaterElementReduction = reader.ReadVarShort();
            pvpAirElementReduction = reader.ReadVarShort();
            pvpFireElementReduction = reader.ReadVarShort();
            dodgePALostProbability = reader.ReadVarUhShort();
            if (dodgePALostProbability < 0)
                throw new System.Exception("Forbidden value on dodgePALostProbability = " + dodgePALostProbability + ", it doesn't respect the following condition : dodgePALostProbability < 0");
            dodgePMLostProbability = reader.ReadVarUhShort();
            if (dodgePMLostProbability < 0)
                throw new System.Exception("Forbidden value on dodgePMLostProbability = " + dodgePMLostProbability + ", it doesn't respect the following condition : dodgePMLostProbability < 0");
            tackleBlock = reader.ReadVarShort();
            tackleEvade = reader.ReadVarShort();
            fixedDamageReflection = reader.ReadVarShort();
            invisibilityState = reader.ReadSByte();
            if (invisibilityState < 0)
                throw new System.Exception("Forbidden value on invisibilityState = " + invisibilityState + ", it doesn't respect the following condition : invisibilityState < 0");
            

}


}


}