using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Clients
{
    public class Account
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Nickname { get; set; }
        public string SecretAnswer { get; set; }
        public string SecretQuestion { get; set; }
        public CharacterRoleEnum Role { get; set; }
    }
}
