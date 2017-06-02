using PetaPoco.NetCore;
using Rebirth.Auth.Managers;
using Rebirth.Auth.Network;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.Auth.Datas
{
    [TableName("servers")]
    public class Server
    {
        #region Variables Bdd

        public uint Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Ip
        {
            get;
            set;
        }

        public uint Port
        {
            get;
            set;
        }

        public uint Type
        {
            get;
            set;
        }
        #endregion

        #region Public Variables
        public ServerStatusEnum State { get; set; }
        #endregion

        #region  Constructeur
        public Server()
        {}
        #endregion

        public GameServerInformations GetGameServerInformations(int accountId)
        {
            var character = ServerManager.Instance.GetWorldCharacter(accountId, (int)Id);
            return new GameServerInformations(Id, (sbyte)Type, (sbyte)State, 0, true, (character != null ? character.Count : (sbyte)0), 5, 0);
        }
    }
}
