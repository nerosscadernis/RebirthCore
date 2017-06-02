

















// Generated on 01/12/2017 03:53:15
using System;
using System.Collections.Generic;
using Rebirth.Common.GameData.D2O;

namespace Rebirth.Common.Protocol.Data
{

[D2oClass("MapScrollActions")]
    
public class MapScrollAction : IDataObject
{

public const String MODULE = "MapScrollActions";
        public int id;
        public Boolean rightExists;
        public Boolean bottomExists;
        public Boolean leftExists;
        public Boolean topExists;
        public int rightMapId;
        public int bottomMapId;
        public int leftMapId;
        public int topMapId;
        

}

}