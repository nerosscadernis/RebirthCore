

















// Generated on 01/12/2017 03:53:14
using System;
using System.Collections.Generic;
using Rebirth.Common.GameData.D2O;

namespace Rebirth.Common.Protocol.Data
{

[D2oClass("AchievementRewards")]
    
public class AchievementReward : IDataObject
{

public const String MODULE = "AchievementRewards";
        public uint id;
        public uint achievementId;
        public int levelMin;
        public int levelMax;
        public List<uint> itemsReward;
        public List<uint> itemsQuantityReward;
        public List<uint> emotesReward;
        public List<uint> spellsReward;
        public List<uint> titlesReward;
        public List<uint> ornamentsReward;
        

}

}