

















// Generated on 01/12/2017 03:53:15
using System;
using System.Collections.Generic;
using Rebirth.Common.GameData.D2O;

namespace Rebirth.Common.Protocol.Data
{

[D2oClass("Areas")]
    
public class Area : IDataObject
{

public const String MODULE = "Areas";
        public int id;
        public uint nameId;
        public int superAreaId;
        public Boolean containHouses;
        public Boolean containPaddocks;
        public Rectangle bounds;
        public uint worldmapId;
        public Boolean hasWorldMap;
        

}

}