using PetaPoco.NetCore;
using Rebirth.Common.Protocol.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Interactives
{
    [TableName("interactive_datas")]
    public class InteractiveDatas
    {
        public int Id
        {
            get;
            set;
        }

        public InteractiveTypeEnum Type { get; set; }
        public int MapId { get; set; }
        public int Data1 { get; set; }
        public int Data2 { get; set; }

    }
}
