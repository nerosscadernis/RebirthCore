

















// Generated on 01/12/2017 03:53:11
using System;
using System.Collections.Generic;
using Rebirth.Common.GameData.D2O;

namespace Rebirth.Common.Protocol.Data
{

[D2oClass("SmileyPacks")]
    
public class SmileyPack : IDataObject
{

public const String MODULE = "SmileyPacks";
        public uint id;
        public uint nameId;
        public uint order;
        public List<uint> smileys;
        

}

}