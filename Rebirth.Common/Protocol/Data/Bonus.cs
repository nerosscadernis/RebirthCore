

















// Generated on 01/12/2017 03:53:10
using System;
using System.Collections.Generic;
using Rebirth.Common.GameData.D2O;

namespace Rebirth.Common.Protocol.Data
{

[D2oClass("Bonuses")]
    
public class Bonus : IDataObject
{

public const String MODULE = "Bonuses";
        public int id;
        public uint type;
        public int amount;
        public List<int> criterionsIds;
        

}

}