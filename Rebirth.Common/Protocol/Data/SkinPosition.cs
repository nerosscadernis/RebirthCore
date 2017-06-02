

















// Generated on 01/12/2017 03:53:10
using System;
using System.Collections.Generic;
using Rebirth.Common.GameData.D2O;

namespace Rebirth.Common.Protocol.Data
{

[D2oClass("SkinPositions")]
    
public class SkinPosition : IDataObject
{

private const String MODULE = "SkinPositions";
        public uint id;
        public List<TransformData> transformation;
        public List<String> clip;
        public List<uint> skin;
        

}

}