

















// Generated on 01/12/2017 03:53:11
using System;
using System.Collections.Generic;
using Rebirth.Common.GameData.D2O;

namespace Rebirth.Common.Protocol.Data
{

[D2oClass("CharacteristicCategories")]
    
public class CharacteristicCategory : IDataObject
{

public const String MODULE = "CharacteristicCategories";
        public int id;
        public uint nameId;
        public int order;
        public List<uint> characteristicIds;
        

}

}