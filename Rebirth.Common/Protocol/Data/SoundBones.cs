

















// Generated on 01/12/2017 03:53:15
using System;
using System.Collections.Generic;
using Rebirth.Common.GameData.D2O;

namespace Rebirth.Common.Protocol.Data
{

[D2oClass("SoundBones")]
    
public class SoundBones : IDataObject
{

public String MODULE = "SoundBones";
        public uint id;
        public List<String> keys;
        public List<List<SoundAnimation>> values;
        

}

}