

















// Generated on 01/12/2017 03:53:11
using System;
using System.Collections.Generic;
using Rebirth.Common.GameData.D2O;

namespace Rebirth.Common.Protocol.Data
{

[D2oClass("ChatChannels")]
    
public class ChatChannel : IDataObject
{

public const String MODULE = "ChatChannels";
        public uint id;
        public uint nameId;
        public uint descriptionId;
        public String shortcut;
        public String shortcutKey;
        public Boolean isPrivate;
        public Boolean allowObjects;
        

}

}