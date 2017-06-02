using PetaPoco.NetCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Characters
{
    [TableName("characters")]
    public class CharacterRecord
    {
        public double Id { get; set; }
        public byte[] Infos { get; set; }
        public byte[] Look { get; set; }
        public byte[] Inventory { get; set; }
        public byte[] Stats { get; set; }
        public byte[] Guild { get; set; }
    }
}
