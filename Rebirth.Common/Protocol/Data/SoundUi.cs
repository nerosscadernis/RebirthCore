

















// Generated on 01/12/2017 03:53:15
using System;
using System.Collections.Generic;
using Rebirth.Common.GameData.D2O;

namespace Rebirth.Common.Protocol.Data
{

[D2oClass("SoundUi")]
    
public class SoundUi : IDataObject
{

public String MODULE = "SoundUi";
        public uint id;
        public String uiName;
        public String openFile;
        public String closeFile;
        public List<SoundUiElement> subElements;
        

}

}