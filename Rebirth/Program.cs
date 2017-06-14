using Rebirth.Common.Network;
using Rebirth.Common.Utils;
using System;
using System.IO;

namespace Rebirth
{
    class Program
    {
        static void Main(string[] args)
        {
            LogManager.Init();
            Console.WriteLine("Choose your type of server : auth | world | all");
            string type = Console.ReadLine();
            Console.Clear();
            GeneralInit();
            switch (type)
            {
                case "auth":
                    AuthInit();
                    Auth.Starter.Init();
                    break;
                case "world":
                    WorldInit();
                    World.Starter.Init();
                    break;
                case "all":
                    AuthInit();
                    WorldInit();
                    Auth.Starter.Init();
                    World.Starter.Init();
                    break;
            }
            Console.ReadKey(true);
        }

        static void GeneralInit()
        {
            MessageReceiver.Initialize();
            ProtocolTypeManager.Initialize();
        }

        static void AuthInit()
        {
            if (!File.Exists(AppContext.BaseDirectory + "\\AuthConfig"))
                Installer.InstallManager.InstallAuth();
            else
                ConfigManager.InitAuth();
        }

        static void WorldInit()
        {
            if (!File.Exists(AppContext.BaseDirectory + "\\WorldConfig"))
                Installer.InstallManager.InstallWorld();
            else
                ConfigManager.InitWorld();
        }
    }
}