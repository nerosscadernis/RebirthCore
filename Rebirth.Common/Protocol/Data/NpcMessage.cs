

















// Generated on 01/12/2017 03:53:14
using System;
using System.Collections.Generic;
using Rebirth.Common.GameData.D2O;

namespace Rebirth.Common.Protocol.Data
{

[D2oClass("NpcMessages")]
    
public class NpcMessage : IDataObject
{

public const String MODULE = "NpcMessages";
        public int id;
        public uint messageId;
        public List<String> messageParams;
        

}

}