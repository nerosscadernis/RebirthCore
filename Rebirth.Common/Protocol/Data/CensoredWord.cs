

















// Generated on 01/12/2017 03:53:11
using System;
using System.Collections.Generic;
using Rebirth.Common.GameData.D2O;

namespace Rebirth.Common.Protocol.Data
{

[D2oClass("CensoredWords")]
    
public class CensoredWord : IDataObject
{

public const String MODULE = "CensoredWords";
        public uint id;
        public uint listId;
        public String language;
        public String word;
        public Boolean deepLooking;
        

}

}