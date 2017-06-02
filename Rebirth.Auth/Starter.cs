using MySql.Data.MySqlClient;
using PetaPoco.NetCore;
using Rebirth.Auth.Managers;
using Rebirth.Auth.Network;
using Rebirth.Common.Network;
using Rebirth.Common.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.Auth
{
    public static class Starter
    {
        public static ServerAuth Server;
        public static ServerWorld WorldServer;
        public static IdentificationTreatment Identification;
        public static Logger Logger;

        private static Object thisLock = new Object();
        private static Database _database;
        public static Database Database
        {
            get
            {
                lock (thisLock)
                {
                    return _database;
                }
            }
            set
            {
                _database = value;
            }
        }

        public static void Init()
        {
            Logger = LogManager.GetLoggerClass();

            Logger.Infos("Starting Auth !");
            int startTime = Environment.TickCount;

            MySqlConnection connection = new MySqlConnection("server=localhost;database=auth;uid=root;password=;charset=utf8;SslMode=None");
            Database = new Database(connection);

            ServerManager.Instance.Init();

            Identification = new IdentificationTreatment();

            WorldServer = new ServerWorld(2000);
            Server = new ServerAuth(443);

            Logger.Infos(string.Format("Throw in {0}ms !", Environment.TickCount - startTime));
        }
    }
}
