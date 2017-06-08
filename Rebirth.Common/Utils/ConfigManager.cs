using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Rebirth.Common.Utils
{
    public static class ConfigManager
    {
        #region Vars
        private static Dictionary<string, dynamic> _auth = new Dictionary<string, dynamic>();
        private static Dictionary<string, dynamic> _world = new Dictionary<string, dynamic>();
        #endregion

        #region Save
        public static void SaveAuth(string path)
        {
            List<string> lines = new List<string>();
            foreach (var item in _auth)
            {
                if (item.Value is string)
                    lines.Add(string.Format("{0}=\"{1}\"", item.Key, item.Value));
                else
                    lines.Add(string.Format("{0}={1}", item.Key, item.Value));
            }
            File.WriteAllLines(path + "\\AuthConfig", lines);
        }
        public static void SaveWorld(string path)
        {
            List<string> lines = new List<string>();
            foreach (var item in _world)
            {
                if (item.Value is string)
                    lines.Add(string.Format("{0}=\"{1}\"", item.Key, item.Value));
                else
                    lines.Add(string.Format("{0}={1}", item.Key, item.Value));
            }
            File.WriteAllLines(path + "\\WorldConfig", lines);
        }
        #endregion

        #region Init
        public static void InitAuth()
        {
            string[] lines = File.ReadAllLines(AppContext.BaseDirectory + "\\AuthConfig");
            foreach (var line in lines)
            {
                var datas = line.Split('=');
                if (datas[1].Contains('"'))
                    _auth.Add(datas[0], datas[1].Replace("\"", "\""));
                else
                    _auth.Add(datas[0], Convert.ToInt32(datas[1]));
            }
        }
        public static void InitWorld()
        {
            var lines = File.ReadAllLines(AppContext.BaseDirectory + "\\WorldConfig");
            foreach (var line in lines)
            {
                var datas = line.Split('=');
                if (datas[1].Contains('"'))
                    _world.Add(datas[0], datas[1].Replace("\"", "\""));
                else
                    _world.Add(datas[0], Convert.ToInt32(datas[1]));
            }
        }
        #endregion

        #region Auth Get / Set
        public static void UpdateInfo<T>(string server, string name, T info) where T : IConvertible
        {
            if (server == "auth")
                _auth[name] = info;
            if (server == "world")
                _world[name] = info;
        }
        public static T GetAuthValue<T>(string name) where T : IConvertible
        {
            if (_auth.ContainsKey(name))
                return (T)_auth[name];
            return default(T);
        }
        #endregion

        #region World Get / Set
        public static T GetWorldValue<T>(string name) where T : IConvertible
        {
            if (_world.ContainsKey(name))
                return (T)_world[name];
            return default(T);
        }
        #endregion
    }
}
