

















// Generated on 01/12/2017 03:53:12
using System;
using System.Collections.Generic;
using Rebirth.Common.GameData.D2O;

namespace Rebirth.Common.Protocol.Data
{
    
    [D2oClass("ItemTypes")]
    
public class ItemType : IDataObject
{

public const String MODULE = "ItemTypes";
        public int id;
        public uint nameId;
        public uint superTypeId;
        public Boolean plural;
        public uint gender;
        public String rawZone;
        public Boolean mimickable;
        public int craftXpRatio;
        

}

}