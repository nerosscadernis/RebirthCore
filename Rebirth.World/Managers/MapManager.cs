using Rebirth.Common.Extensions;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.GameData.Maps;
using Rebirth.Common.Protocol.Data;
using Rebirth.World.Datas.Interactives.Types;
using Rebirth.World.Datas.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rebirth.World.Managers
{
    public class MapManager : DataManager<MapManager>
    {
        private List<MapTemplate> _maps = new List<MapTemplate>();
        private List<MapPosition> _coordinates;
        private List<Zaapi> _zappis = new List<Zaapi>();

        public void Init()
        {
            _coordinates = ObjectDataManager.GetAll<MapPosition>();
        }

        public MapTemplate GetMap(int id)
        {
            if (!_maps.Any(x => x.Id == id))
                _maps.Add(new MapTemplate(MapsManager.GetMapFromId(id)));
            return _maps.First(x => x.Id == id);
        }

        public MapTemplate GetMap(int x, int y, bool hasPriority, int worldMap, int currentMapPosition, bool outDoor)
        {
            var maps = _coordinates.FindAll(v => v.posX == x && v.posY == y);
            var newMap = maps.FirstOrDefault(b => b.posX == x && b.posY == y && b.outdoor == outDoor && b.worldMap == worldMap && b.hasPriorityOnWorldmap == hasPriority);
            if (newMap == null)
                newMap = maps.FirstOrDefault(b => b.posX == x && b.posY == y && b.outdoor == outDoor && b.worldMap == worldMap && b.hasPriorityOnWorldmap);

            return GetMap(newMap.id);
        }

        #region Zaapi
        private List<int> SubAreaBonta = new List<int>()
        {
            46, 47, 48, 49, 50, 51, 513, 530, 532, 533
        };
        private List<int> SubAreaBrakmar = new List<int>()
        {
            502, 507, 535, 511, 508, 531, 505, 503, 506, 534, 509
        };

        public void AddZaapi(Zaapi zaapi)
        {
            _zappis.Add(zaapi);
        }

        public List<Zaapi> GetZaapiBySub(int sub)
        {
            if (SubAreaBonta.Contains(sub))
                return _zappis.FindAll(x => SubAreaBonta.Contains(x.SubArea));
            else
                return _zappis.FindAll(x => SubAreaBrakmar.Contains(x.SubArea));
        }
        public bool HisGoodSub(int sub, int subDest)
        {
            if (SubAreaBonta.Contains(sub))
                return SubAreaBonta.Contains(subDest);
            else
                return SubAreaBrakmar.Contains(subDest);
        }
        #endregion
    }
}
