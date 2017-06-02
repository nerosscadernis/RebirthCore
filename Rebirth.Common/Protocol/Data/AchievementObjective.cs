

















// Generated on 01/12/2017 03:53:14
using System;
using System.Collections.Generic;
using Rebirth.Common.GameData.D2O;

namespace Rebirth.Common.Protocol.Data
{

[D2oClass("AchievementObjectives")]
    
public class AchievementObjective : IDataObject
{

public const String MODULE = "AchievementObjectives";
        public uint id;
        public uint achievementId;
        public uint order;
        public uint nameId;
        public String criterion;
        

}

}