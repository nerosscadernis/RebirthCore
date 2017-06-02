

















// Generated on 01/12/2017 03:53:14
using System;
using System.Collections.Generic;
using Rebirth.Common.GameData.D2O;

namespace Rebirth.Common.Protocol.Data
{

[D2oClass("CompanionSpells")]
    
public class CompanionSpell : IDataObject
{

public const String MODULE = "CompanionSpells";
        public int id;
        public int spellId;
        public int companionId;
        public String gradeByLevel;
        

}

}