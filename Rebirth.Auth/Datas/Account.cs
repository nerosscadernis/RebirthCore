using PetaPoco.NetCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.Auth.Datas
{
    [TableName("accounts")]
    public class Account
    {
        #region Variables Bdd
        public int Id
        {
            get;
            set;
        }

        public string Login
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public string Mail
        {
            get;
            set;
        }

        public string HeureVote
        {
            get;
            set;
        }

        public int VoteNumbers
        {
            get;
            set;
        }

        public string Nickname
        {
            get;
            set;
        }

        public CharacterRoleEnum Role
        {
            get;
            set;
        }

        public string SecretQuestion
        {
            get;
            set;
        }

        public string SecretAnswer
        {
            get;
            set;
        }

        public string BanReason
        {
            get;
            set;
        }

        public string Ticket
        {
            get;
            set;
        }

        public uint LastServer
        {
            get;
            set;
        }

        public string LastIp
        {
            get;
            set;
        }

        public string LastDate
        {
            get;
            set;
        }

        public int ShopPoints
        {
            get;
            set;
        }

        public int EventPoints
        {
            get;
            set;
        }
        #endregion

        #region Variables
        public byte[] AesKey { get; set; }
        public string actualIp;
        #endregion
    }
}
