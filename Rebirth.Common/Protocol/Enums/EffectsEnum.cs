﻿using System;
namespace Rebirth.Common.Protocol.Enums
{
    public enum EffectsEnum : short
    {
        Effect_Teleport = 4,
        Effect_PushBack,
        Effect_PullForward,
        Effect_Divorce,
        Effect_SwitchPosition,
        Effect_Dodge,
        Effect_LearnAttitude,
        Effect_13 = 13,
        Effect_34 = 34,
        Effect_Porter = 50,
        Effect_Lancer,
        Effect_SubMPFix = 56,
        Effect_StealMP_77 = 77,
        Effect_AddMP,
        Effect_79,
        Effect_HealHP_81 = 81,
        Effect_StealHPFix,
        Effect_StealAP_84 = 84,
        Effect_DamagePercentWater,
        Effect_DamagePercentEarth,
        Effect_DamagePercentAir,
        Effect_DamagePercentFire,
        Effect_DamagePercentNeutral,
        Effect_GiveHPPercent,
        Effect_StealHPWater,
        Effect_StealHPEarth,
        Effect_StealHPAir,
        Effect_StealHPFire,
        Effect_StealHPNeutral,
        Effect_DamageWater,
        Effect_DamageEarth,
        Effect_DamageAir,
        Effect_DamageFire,
        Effect_DamageNeutral,
        Effect_RemoveAP,
        Effect_AddGlobalDamageReduction_105 = 105,
        Effect_ReflectSpell,
        Effect_AddDamageReflection,
        Effect_HealHP_108,
        Effect_109,
        Effect_AddHealth,
        Effect_AddAP_111,
        Effect_AddDamageBonus,
        Effect_DoubleDamageOrRestoreHP,
        Effect_AddDamageMultiplicator,
        Effect_AddCriticalHit,
        Effect_SubRange,
        Effect_AddRange,
        Effect_AddStrength,
        Effect_AddAgility,
        Effect_RegainAP,
        Effect_AddDamageBonus_121,
        Effect_AddCriticalMiss,
        Effect_AddChance,
        Effect_AddWisdom,
        Effect_AddVitality,
        Effect_AddIntelligence,
        Effect_LostMP,
        Effect_AddMP_128,
        Effect_StealKamas = 130,
        Effect_LoseHPByUsingAP,
        Effect_DispelMagicEffects,
        Effect_LosingAP,
        Effect_LosingMP,
        Effect_SubRange_135,
        Effect_AddRange_136,
        Effect_AddPhysicalDamage_137,
        Effect_IncreaseDamage_138,
        Effect_RestoreEnergyPoints,
        Effect_SkipTurn,
        Effect_Kill,
        Effect_AddPhysicalDamage_142,
        Effect_HealHP_143,
        Effect_DamageFix,
        Effect_SubDamageBonus,
        Effect_ChangesWords,
        Effect_ReviveAlly,
        Effect_Followed,
        Effect_ChangeAppearance,
        Effect_Invisibility,
        Effect_SubChance = 152,
        Effect_SubVitality,
        Effect_SubAgility,
        Effect_SubIntelligence,
        Effect_SubWisdom,
        Effect_SubStrength,
        Effect_IncreaseWeight,
        Effect_DecreaseWeight,
        Effect_IncreaseAPAvoid,
        Effect_IncreaseMPAvoid,
        Effect_SubDodgeAPProbability,
        Effect_SubDodgeMPProbability,
        Effect_AddGlobalDamageReduction,
        Effect_AddDamageBonusPercent,
        Effect_166,
        Effect_SubAP = 168,
        Effect_SubMP,
        Effect_SubCriticalHit = 171,
        Effect_SubMagicDamageReduction,
        Effect_SubPhysicalDamageReduction,
        Effect_AddInitiative,
        Effect_SubInitiative,
        Effect_AddProspecting,
        Effect_SubProspecting,
        Effect_AddHealBonus,
        Effect_SubHealBonus,
        Effect_Double,
        Effect_Summon,
        Effect_AddSummonLimit,
        Effect_AddMagicDamageReduction,
        Effect_AddPhysicalDamageReduction,
        Effect_185,
        Effect_SubDamageBonusPercent,
        Effect_188 = 188,
        Effect_TemporyStats = 193,
        Effect_GiveKamas,
        Effect_197 = 197,
        Effect_201 = 201,
        Effect_RevealsInvisible,
        Effect_206 = 206,
        Effect_AddEarthResistPercent = 210,
        Effect_AddWaterResistPercent,
        Effect_AddAirResistPercent,
        Effect_AddFireResistPercent,
        Effect_AddNeutralResistPercent,
        Effect_SubEarthResistPercent,
        Effect_SubWaterResistPercent,
        Effect_SubAirResistPercent,
        Effect_SubFireResistPercent,
        Effect_SubNeutralResistPercent,
        Effect_220,
        Effect_221,
        Effect_222,
        Effect_AddTrapBonus = 225,
        Effect_AddTrapBonusPercent,
        Effect_229 = 229,
        Effect_230,
        Effect_239 = 239,
        Effect_AddEarthElementReduction,
        Effect_AddWaterElementReduction,
        Effect_AddAirElementReduction,
        Effect_AddFireElementReduction,
        Effect_AddNeutralElementReduction,
        Effect_SubEarthElementReduction,
        Effect_SubWaterElementReduction,
        Effect_SubAirElementReduction,
        Effect_SubFireElementReduction,
        Effect_SubNeutralElementReduction,
        Effect_AddPvpEarthResistPercent,
        Effect_AddPvpWaterResistPercent,
        Effect_AddPvpAirResistPercent,
        Effect_AddPvpFireResistPercent,
        Effect_AddPvpNeutralResistPercent,
        Effect_SubPvpEarthResistPercent,
        Effect_SubPvpWaterResistPercent,
        Effect_SubPvpAirResistPercent,
        Effect_SubPvpFireResistPercent,
        Effect_SubPvpNeutralResistPercent,
        Effect_AddPvpEarthElementReduction,
        Effect_AddPvpWaterElementReduction,
        Effect_AddPvpAirElementReduction,
        Effect_AddPvpFireElementReduction,
        Effect_AddPvpNeutralElementReduction,
        Effect_AddArmorDamageReduction,
        Effect_StealChance,
        Effect_StealVitality,
        Effect_StealAgility,
        Effect_StealIntelligence,
        Effect_StealWisdom,
        Effect_StealStrength,
        Effect_275 = 275,
        Effect_276,
        Effect_277,
        Effect_278,
        Effect_279,
        Effect_BoostSpellPO = 281,
        Effect_282,
        Effect_283,
        Effect_284,
        Effect_285,
        Effect_286,
        Effect_287,
        Effect_288,
        Effect_289,
        Effect_290,
        Effect_291,
        Effect_292,
        Effect_SpellBoostDamage,
        Effect_294,
        Effect_310 = 310,
        Effect_StealRange = 320,
        Effect_333 = 333,
        Effect_ChangeAppearance_335 = 335,
        Effect_Trap = 400,
        Effect_Glyph,
        Effect_Glyph_402,
        Effect_Kill_405 = 405,
        Effect_Debuff,
        Effect_407,
        Effect_APAttack = 410,
        Effect_411,
        Effect_412,
        Effect_SubPMAttack,
        Effect_AddPushDamageBonus,
        Effect_SubPushDamageBonus,
        Effect_AddPushDamageReduction,
        Effect_SubPushDamageReduction,
        Effect_AddCriticalDamageBonus,
        Effect_SubCriticalDamageBonus,
        Effect_AddCriticalDamageReduction,
        Effect_SubCriticalDamageReduction,
        Effect_AddEarthDamageBonus,
        Effect_SubEarthDamageBonus,
        Effect_AddFireDamageBonus,
        Effect_SubFireDamageBonus,
        Effect_AddWaterDamageBonus,
        Effect_SubWaterDamageBonus,
        Effect_AddAirDamageBonus,
        Effect_SubAirDamageBonus,
        Effect_AddNeutralDamageBonus,
        Effect_SubNeutralDamageBonus,
        Effect_StealAP_440 = 440,
        Effect_StealMP_441,
        Effect_Prisme = 513,
        Effect_600 = 600,
        Effect_601,
        Effect_602,
        Effect_603,
        Effect_LearnSpell,
        Effect_605,
        Effect_AddPermanentWisdom,
        Effect_AddPermanentStrength,
        Effect_AddPermanentChance,
        Effect_AddPermanentAgility,
        Effect_AddPermanentVitality,
        Effect_AddPermanentIntelligence,
        Effect_612,
        Effect_AddSpellPoints,
        Effect_614,
        Effect_615,
        Effect_616,
        Effect_620 = 620,
        Effect_621,
        Effect_622,
        Effect_623,
        Effect_624,
        Effect_625,
        Effect_626,
        Effect_627,
        Effect_628,
        Effect_631 = 631,
        Effect_640 = 640,
        Effect_641,
        Effect_642,
        Effect_643,
        Effect_645 = 645,
        Effect_646,
        Effect_647,
        Effect_648,
        Effect_649,
        Effect_654 = 654,
        Effect_Sacrifice = 666,
        Effect_669 = 669,
        Effect_670,
        Effect_671,
        Effect_Punishment_Damage,
        Effect_699 = 699,
        Effect_700,
        Effect_701,
        Effect_702,
        Effect_705 = 705,
        Effect_706,
        Effect_707,
        Effect_710 = 710,
        Effect_715 = 715,
        Effect_716,
        Effect_717,
        Effect_720 = 720,
        Effect_Add_Title = 724,
        Effect_725,
        Effect_730 = 730,
        Effect_731,
        Effect_732,
        Effect_740 = 740,
        Effect_741,
        Effect_742,
        Effect_750 = 750,
        Effect_751,
        Effect_AddDodge,
        Effect_AddLock,
        Effect_SubDodge,
        Effect_SubLock,
        Effect_760 = 760,
        Effect_Sacrifice1 = 765,
        Effect_770 = 770,
        Effect_771,
        Effect_772,
        Effect_773,
        Effect_774,
        Effect_775,
        Effect_AddErosion,
        Effect_780 = 780,
        Effect_Poisse,
        Effect_Brokle,
        Effect_RepelsTo,
        Effect_Rollback,
        Effect_785,
        Effect_HealByAttack,
        Effect_787,
        Effect_Punishment,
        Effect_789,
        Effect_790,
        Effect_791,
        Effect_SpellExecute,
        Effect_SpellExecute1,
        Effect_795 = 795,
        Effect_800 = 800,
        Effect_805 = 805,
        Effect_806,
        Effect_807,
        Effect_LastMeal,
        Effect_810 = 810,
        Effect_RemainingFights,
        Effect_812,
        Effect_813,
        Effect_814,
        Effect_815,
        Effect_816,
        Effect_825 = 825,
        Effect_905 = 905,
        Effect_930 = 930,
        Effect_931,
        Effect_932,
        Effect_933,
        Effect_934,
        Effect_935,
        Effect_936,
        Effect_937,
        Effect_939 = 939,
        Effect_940,
        Effect_946 = 946,
        Effect_947,
        Effect_948,
        Effect_949,
        Effect_AddState,
        Effect_RemoveState,
        Effect_952,
        Effect_960 = 960,
        Effect_961,
        Effect_962,
        Effect_963,
        Effect_964,
        Effect_LivingObjectId = 970,
        Effect_LivingObjectMood,
        Effect_LivingObjectSkin,
        Effect_LivingObjectCategory,
        Effect_LivingObjectLevel,
        Effect_NonExchangeable_981 = 981,
        Effect_NonExchangeable_982,
        Effect_Mimibiote,
        Effect_984,
        Effect_985,
        Effect_986,
        Effect_987,
        Effect_988,
        Effect_989,
        Effect_990,
        Effect_994 = 994,
        Effect_995,
        Effect_996,
        Effect_997,
        Effect_998,
        Effect_999,
        Effect_1002 = 1002,
        Effect_1003,
        Effect_1004,
        Effect_1005,
        Effect_1006,
        Effect_1007,
        Effect_Bomb,
        Effect_DeclanchBomb,
        Effect_1010,
        Effect_1011,
        Effect_1012,
        Effect_1013,
        Effect_1014,
        Effect_DamageByPMFire,
        Effect_1016,
        Effect_SpellExecute_Caster,
        Effect_1018,
        Effect_1019,
        Effect_1021 = 1021,
        Effect_1022,
        Effect_1023,
        Effect_1024,
        Effect_1025,
        Effect_DeclanchGlyph,
        Effect_1027,
        Effect_1028,
        Effect_1029,
        Effect_1030,
        Effect_PassTurn,
        Effect_1032,
        Effect_SubLifePourcent_1033,
        Effect_1034,
        Effect_1035,
        Effect_1036,
        Effect_1037,
        Effect_1038,
        Effect_AddShieldPercent,
        Effect_AddShield,
        Effect_Back,
        Effect_BePulled,
        Effect_1043,
        Effect_1044,
        Effect_ReducCooldown,
        Effect_1046,
        Effect_1047,
        Effect_SubLifePourcent,
        Effect_1049,
        Effect_1050,
        Effect_1051,
        Effect_1052,
        Effect_1053,
        Effect_IncreaseDamage_1054,
        Effect_1055,
        Effect_1057 = 1057,
        Effect_1058,
        Effect_1059,
        Effect_1060,
        Effect_DamageSharing,
        Effect_1062,
        Effect_1063,
        Effect_1064,
        Effect_1065,
        Effect_AddGlyphBonusPercent,
        Effect_1067,
        Effect_1068,
        Effect_1069,
        Effect_1070,
        Effect_1071,
        Effect_1072,
        Effect_1073,
        Effect_1074,
        Effect_ReduceEffectsDuration,
        Effect_AddResistances,
        Effect_SubResistances,
        Effect_AddVitalityPercent,
        Effect_Remove_PA,
        Effect_SubMP_1080,
        Effect_1081,
        Effect_1082,
        Effect_1083,
        Effect_1084,
        Effect_1085,
        Effect_1086,
        Effect_1087,
        Effect_Glyph_1091 = 1091,
        Effect_1092,
        Effect_Erosion_Air,
        Effect_Erosion_Fire,
        Effect_1095,
        Effect_1096,
        Effect_Illus,
        Effect_1098,
        Effect_1099,
        Effect_PreviousPosition,
        Effect_1101,
        Effect_1102,
        Effect_PushBack_1103,
        Effect_My_Sysmetrie,
        Effect_Teleporte_Symetrie,
        Effect_My_Sysmetrie_bis,
        Effect_1107,
        Effect_1108,
        Effect_RestoreHPPercent,
        Effect_1111 = 1111,
        Effect_1118 = 1118,
        Effect_1119,
        Effect_1120,
        Effect_1121,
        Effect_1122,
        Effect_Poutch,
        Effect_1124,
        Effect_1125,
        Effect_1126,
        Effect_1127,
        Effect_1128,
        Effect_1129,
        Effect_DamageAirPerAP = 1131,
        Effect_DamageWaterPerAP,
        Effect_DamageFirePerAP,
        Effect_DamageNeutralPerAP,
        Effect_DamageEarthPerAP,
        Effect_DamageAirPerMP,
        Effect_DamageWaterPerMP,
        Effect_DamageFirePerMP,
        Effect_DamageNeutralPerMP,
        Effect_DamageEarthPerMP,
        Effect_1141,
        Effect_1142,
        Effect_HealMultiplicator = 1159,
        Effect_ExecuteSpell,
        Effect_Heal_Before_Attacked = 1164,
        Effect_MultiplicatorDamage = 1163,
        Effect_AddFinalDommagePourcent = 1171,
        Effect_AddPortail = 1181,
        Effect_UnmarkPortail = 1183,
        Effect_Heal_Last_Damage = 2020,
        Effect_ControlSummon = 2027,
        Effect_StatsSummon,
        End
    }
}
