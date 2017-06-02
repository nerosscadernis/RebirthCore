using Rebirth.Common.Network;
using Rebirth.Common.Utils;
using System;

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
                    Auth.Starter.Init();
                    break;
                case "world":
                    World.Starter.Init();
                    break;
                case "all":
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
    }
}