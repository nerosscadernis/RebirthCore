using PetaPoco.NetCore;
using Pomelo.Data.MySql;
using Rebirth.Common.Protocol.Messages;
using System;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Network;
using Rebirth.World.Managers;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Utils;
using Rebirth.World.Network;
using Rebirth.Common.GameData.Maps;

namespace Rebirth.World
{
    public static class Starter
    {
        private static Object thisLock = new Object();
        private static Database _database;
        public static Database Database
        {
            get
            {
                lock(thisLock)
                {
                    return _database;
                }
            }
            set
            {
                _database = value;
            }
        }

        public static Client AuthClient;
        public static WorldServer Server;
        public static Logger Logger;

        public static void Init()
        {
            Logger = LogManager.GetLoggerClass();
            Logger.Infos("Starting World !");
            int startTime = Environment.TickCount;

            AuthClient = new Client("127.0.0.1", 2000);
            AuthClient.Send(new UpdateStatuServerMessage(ServerStatusEnum.STARTING, 1));

            MySqlConnection connection = new MySqlConnection("server=localhost;database=world;uid=root;password=;charset=utf8;SslMode=None");
            Database = new Database(connection);

            // Charge les chemins d'accès d2o
            ObjectDataManager.Initialize(".\\common");

            MapsManager.Initialize(".\\maps");

            InteractiveManager.Instance.Init();
            CharacterManager.Instance.Init();
            ExperienceManager.Instance.Initialize();
            MapManager.Instance.Init();

            Server = new WorldServer(5555);

            AuthClient.Send(new UpdateStatuServerMessage(ServerStatusEnum.ONLINE, 1));
            Logger.Infos(string.Format("Throw in {0}ms !", Environment.TickCount - startTime));
        }
    }
}
