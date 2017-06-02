

















// Generated on 01/12/2017 03:53:14
using System;
using System.Collections.Generic;
using Rebirth.Common.GameData.D2O;

namespace Rebirth.Common.Protocol.Data
{

[D2oClass("Quests")]
    
public class Quest : IDataObject
{

public const String MODULE = "Quests";
        public uint id;
        public uint nameId;
        public List<uint> stepIds;
        public uint categoryId;
        public uint repeatType;
        public uint repeatLimit;
        public Boolean isDungeonQuest;
        public uint levelMin;
        public uint levelMax;
        public Boolean isPartyQuest;
        public String startCriterion;
        

}

}