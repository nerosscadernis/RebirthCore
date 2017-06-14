using MySql.Data.MySqlClient;
using Rebirth.Common.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Rebirth.Installer
{
    public static class InstallManager
    {

        public static void InstallAuth()
        {
            dynamic value;
            Socket socket;
            bool portValide = false;

            Console.WriteLine("Configuration de l'Auth !");

            Console.WriteLine("Database Adress :");
            value = Console.ReadLine();
            ConfigManager.UpdateInfo<string>("auth", "db_ip", value);

            Console.WriteLine("Database Name :");
            value = Console.ReadLine();
            ConfigManager.UpdateInfo<string>("auth", "db_name", value);

            Console.WriteLine("Database User :");
            value = Console.ReadLine();
            ConfigManager.UpdateInfo<string>("auth", "db_user", value);

            Console.WriteLine("Database Pass :");
            value = Console.ReadLine();
            ConfigManager.UpdateInfo<string>("auth", "db_pass", value);

            Console.WriteLine("Auth Port :");
            do
            {
                try
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    portValide = false;
                    value = Convert.ToInt32(Console.ReadLine());
                    var localEndPoint = new IPEndPoint(IPAddress.Loopback, value);
                    socket.Bind(localEndPoint);
                    socket.Listen(100);
                    socket.Dispose();
                    portValide = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Port {0} unavaible ! Please choose one other.", value);
                    portValide = false;
                }
            }
            while (!portValide);
            ConfigManager.UpdateInfo<int>("auth", "port", value);

            Console.WriteLine("Inter Connexion Port :");
            do
            {
                try
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    portValide = false;
                    value = Convert.ToInt32(Console.ReadLine());
                    var localEndPoint = new IPEndPoint(IPAddress.Loopback, value);
                    socket.Bind(localEndPoint);
                    socket.Listen(100);
                    socket.Dispose();
                    portValide = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Port {0} unavaible ! Please choose one other.", value);
                    portValide = false;
                }
            }
            while (!portValide);
            ConfigManager.UpdateInfo<int>("auth", "inter_port", value);
            ConfigManager.SaveAuth(AppContext.BaseDirectory);

            Console.WriteLine("Config ended. Do you want install AuthSql ? [y|n]");
            if(Console.ReadKey().Key == ConsoleKey.Y)
            {
                string connectionString = string.Format("SERVER={0}; DATABASE={1}; UID={2}; PASSWORD={3}",
                    ConfigManager.GetAuthValue<string>("db_ip"), ConfigManager.GetAuthValue<string>("db_name"), 
                    ConfigManager.GetAuthValue<string>("db_user"), ConfigManager.GetAuthValue<string>("db_pass"));
                var connection = new MySqlConnection(connectionString);
                var script = new MySqlScript(connection, File.ReadAllText(AppContext.BaseDirectory + "\\auth.sql"));
                try
                {
                    script.Execute();
                }
                catch (Exception ex)
                {
                    LogManager.GetLoggerClass().Error(ex.Message);
                }
            }
            Console.Clear();
        }

        public static void InstallWorld()
        {
            dynamic value;
            Socket socket;
            bool portValide = false;

            Console.WriteLine("Configuration du World !");

            Console.WriteLine("Database Adress :");
            value = Console.ReadLine();
            ConfigManager.UpdateInfo<string>("world", "db_ip", value);

            Console.WriteLine("Database Name :");
            value = Console.ReadLine();
            ConfigManager.UpdateInfo<string>("world", "db_name", value);

            Console.WriteLine("Database User :");
            value = Console.ReadLine();
            ConfigManager.UpdateInfo<string>("world", "db_user", value);

            Console.WriteLine("Database Pass :");
            value = Console.ReadLine();
            ConfigManager.UpdateInfo<string>("world", "db_pass", value);

            Console.WriteLine("World Port :");
            do
            {
                try
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    portValide = false;
                    value = Convert.ToInt32(Console.ReadLine());
                    var localEndPoint = new IPEndPoint(IPAddress.Loopback, value);
                    socket.Bind(localEndPoint);
                    socket.Listen(100);
                    socket.Dispose();
                    portValide = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Port {0} unavaible ! Please choose one other.", value);
                    portValide = false;
                }
            }
            while (!portValide);
            ConfigManager.UpdateInfo<int>("world", "port", value);

            Console.WriteLine("Inter Connexion Port :");
            do
            {
                try
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    portValide = false;
                    value = Convert.ToInt32(Console.ReadLine());
                    var localEndPoint = new IPEndPoint(IPAddress.Loopback, value);
                    socket.Bind(localEndPoint);
                    socket.Listen(100);
                    socket.Dispose();
                    portValide = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Port {0} unavaible ! Please choose one other.", value);
                    portValide = false;
                }
            }
            while (!portValide);
            ConfigManager.UpdateInfo<int>("world", "inter_port", value);

            Console.WriteLine("Server Id :");
            value = Console.ReadLine();
            ConfigManager.UpdateInfo<int>("world", "server_id", Convert.ToInt32(value));

            Console.WriteLine("Rate Exp Fight :");
            value = Console.ReadLine();
            ConfigManager.UpdateInfo<int>("world", "rate_fight", Convert.ToInt32(value));

            Console.WriteLine("Rate Exp Job :");
            value = Console.ReadLine();
            ConfigManager.UpdateInfo<int>("world", "rate_job", Convert.ToInt32(value));

            Console.WriteLine("Rate Exp Mount : (add to fight)");
            value = Console.ReadLine();
            ConfigManager.UpdateInfo<int>("world", "rate_mount", Convert.ToInt32(value));

            Console.WriteLine("Rate Exp Guild : (add to fight)");
            value = Console.ReadLine();
            ConfigManager.UpdateInfo<int>("world", "rate_guild", Convert.ToInt32(value));

            Console.WriteLine("Rate Kamas :");
            value = Console.ReadLine();
            ConfigManager.UpdateInfo<int>("world", "rate_kamas", Convert.ToInt32(value));

            ConfigManager.SaveWorld(AppContext.BaseDirectory);

            Console.WriteLine("Config ended. Do you want install WorldSql ? [y|n]");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                string connectionString = string.Format("SERVER={0}; DATABASE={1}; UID={2}; PASSWORD={3}",
                    ConfigManager.GetWorldValue<string>("db_ip"), ConfigManager.GetWorldValue<string>("db_name"),
                    ConfigManager.GetWorldValue<string>("db_user"), ConfigManager.GetWorldValue<string>("db_pass"));
                var connection = new MySqlConnection(connectionString);
                var script = new MySqlScript(connection, File.ReadAllText(AppContext.BaseDirectory + "\\world.sql"));
                try
                {
                    script.Execute();
                }
                catch (Exception ex)
                {
                    LogManager.GetLoggerClass().Error(ex.Message);
                }
            }
            Console.Clear();
        }
    }
}
