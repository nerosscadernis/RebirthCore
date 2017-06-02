using PetaPoco.NetCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.Auth.Datas
{
    [TableName("worlds_characters")]
    public class WorldCharacter
    {
        public int Id { get; set; }
        public sbyte Count { get; set; }
        public int AccountId { get; set; }
        public int ServerId { get; set; }
    }
}
