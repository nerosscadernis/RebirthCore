

















// Generated on 01/12/2017 03:53:11
using System;
using System.Collections.Generic;
using Rebirth.Common.GameData.D2O;

namespace Rebirth.Common.Protocol.Data
{

[D2oClass("Documents")]
    
public class Document : IDataObject
{

private const String MODULE = "Documents";
        public int id;
        public uint typeId;
        public Boolean showTitle;
        public Boolean showBackgroundImage;
        public uint titleId;
        public uint authorId;
        public uint subTitleId;
        public uint contentId;
        public String contentCSS;
        public String clientProperties;
        

}

}