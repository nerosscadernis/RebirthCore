

















// Generated on 01/12/2017 03:53:14
using System;
using System.Collections.Generic;
using Rebirth.Common.GameData.D2O;

namespace Rebirth.Common.Protocol.Data
{

[D2oClass("AchievementCategories")]
    
public class AchievementCategory : IDataObject
{

public const String MODULE = "AchievementCategories";
        public uint id;
        public uint nameId;
        public uint parentId;
        public String icon;
        public uint order;
        public String color;
        public List<uint> achievementIds;
        

}

}