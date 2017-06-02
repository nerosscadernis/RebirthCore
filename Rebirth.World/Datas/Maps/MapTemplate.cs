using Rebirth.Common.Extensions;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.GameData.Elements.Test;
using Rebirth.Common.GameData.Maps;
using Rebirth.Common.GameData.Maps.Elements;
using Rebirth.Common.IStructures;
using Rebirth.Common.Network;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Thread;
using Rebirth.World.Datas.Characters;
using Rebirth.World.Datas.Interactives.Types;
using Rebirth.World.Datas.Interactives.Types.Classic;
using Rebirth.World.Managers;
using Rebirth.World.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rebirth.World.Datas.Maps
{
    public class MapTemplate
    {
        #region Vars
        private List<AbstractInteractive> _interactives = new List<AbstractInteractive>();
        private List<CellTrigger> _triggers = new List<CellTrigger>();
        #endregion

        #region Properties
        public List<Client> Clients { get; set; }
        public MapPosition Coordinates { get; set; }
        public List<CellMap> Cells { get; set; }
        public int Id { get; set; }
        public int SubArea { get; set; }
        #endregion

        #region Constructor
        public MapTemplate(Map map)
        {
            Id = map.Id;
            SubArea = map.SubAreaId;
            Clients = new List<Client>();
            Coordinates = ObjectDataManager.Get<MapPosition>(map.Id);

            Cells = map.Cells.Select(x => new CellMap(x, map.Cells.IndexOf(x))).ToList();
            InitInteractive(map);
        }
        #endregion

        #region Enter | Quit
        public void Enter(Client client)
        {
            Send(new GameRolePlayShowActorMessage(client.Character.GetGameRolePlayCharacterInformations()));
            Clients.Add(client); 

            client.Character.Map = this;
            client.Send(new CurrentMapMessage(Id, "649ae451ca33ec53bbcbcc33becf15f4"));

            client.Send(new BasicTimeMessage(System.DateTime.Now.DateTimeToUnixTimestamp(), 0));
        }
        public void Quit(Client client)
        {
            Clients.Remove(client);
            Send(new GameContextRemoveElementMessage(client.Character.Infos.Id));
        }
        #endregion

        #region Interactives
        public void InitInteractive(Map map)
        {
            EleReader reader = new EleReader(".\\maps\\elements.ele");
            var ele = reader.ReadElements();
            // recupere Identifier qui est egale au ElementId que le serveur doit envoyer
            List<int> Identifierlist = (from x in map.Layers
                                        from i in x.Cells
                                        from y in i.Elements
                                        where y is GraphicalElement && (y as GraphicalElement).Identifier != 0
                                        select (y as GraphicalElement).Identifier).ToList();
            if (map.Cells.Any(x => x.Red) && map.Cells.Any(x => x.Blue))
            {
                AbstractInteractive sleep = new InteractiveZaap(0, 0);
            }

            List<int> ElementIdlist = (from x in map.Layers
                                       from i in x.Cells
                                       from y in i.Elements
                                       where y is GraphicalElement && Identifierlist.Contains((y as GraphicalElement).Identifier)
                                       select (y as GraphicalElement).ElementId).ToList();

            List<int> ElementHorsMap = (from x in map.Layers
                                        from i in x.Cells
                                        from y in i.Elements
                                        where y is GraphicalElement && Identifierlist.Contains((y as GraphicalElement).Identifier) && ((y as GraphicalElement).OffsetX < -50 || (y as GraphicalElement).OffsetX > 50)
                                        select (y as GraphicalElement).Identifier).ToList();

            List<int> CellIds = (from x in map.Layers
                                 from i in x.Cells
                                 from y in i.Elements
                                 where y is GraphicalElement && Identifierlist.Contains((y as GraphicalElement).Identifier)
                                 select i.CellId).ToList();

            int r = 0;
            foreach (var item in ElementIdlist)
            {
                EleGraphicalData element = ele.GraphicalDatas.FirstOrDefault(x => x.Value.Id == item).Value;
                if (element != null)
                {
                    switch (element.Type)
                    {
                        case EleGraphicalElementTypes.BLENDED:
                        case EleGraphicalElementTypes.NORMAL:
                        case EleGraphicalElementTypes.BOUNDING_BOX:
                        case EleGraphicalElementTypes.ANIMATED:
                            InteractiveManager.Instance.GetInteractiveMap(this, (element as NormalGraphicalElementData).Gfx.ToString(), 
                                Identifierlist[r], (uint)CellIds[r], !ElementHorsMap.Contains(Identifierlist[r]), SubArea);
                            break;
                        case EleGraphicalElementTypes.ENTITY:
                            InteractiveManager.Instance.GetInteractiveMap(this, (element as EntityGraphicalElementData).EntityLook, 
                                Identifierlist[r], (uint)CellIds[r], !ElementHorsMap.Contains(Identifierlist[r]), SubArea);
                            break;
                        default:
                            break;
                    }
                }
                r++;
            }
        }

        public void UpdateInteractive(Ressource interactive)
        {
            foreach (var client in Clients)
            {
                var datass = new StatedElementUpdatedMessage(interactive.GetStatedElement());
                client.Send(datass);
                var datas = new InteractiveElementUpdatedMessage(interactive.GetInteractiveElement(client.Character));
                client.Send(datas);
            }
        }

        public AbstractInteractive GetInterctive(int id)
        {
            return _interactives.FirstOrDefault(x => x.Identifier == id);
        }

        public List<AbstractInteractive> GetInterctives()
        {
            return _interactives;
        }

        public InteractiveElement[] GetInteractives(Character character)
        {
            return (from x in _interactives
                    select x.GetInteractiveElement(character)).ToArray();
        }

        public StatedElement[] GetStatedElements()
        {
            return (from x in _interactives
                    where x is IStatedElement
                    select (x as IStatedElement).GetStatedElement()).ToArray();
        }

        public void AddInteractive(AbstractInteractive interactive)
        {
            _interactives.Add(interactive);
            if (interactive is Ressource)
            {

            }
        }

        public AbstractInteractive GetZaap()
        {
            return _interactives.FirstOrDefault(x => x is InteractiveZaap);
        }

        public AbstractInteractive GetZaapi()
        {
            return _interactives.FirstOrDefault(x => x is InteractiveZaapi);
        }

        public void AddTriggers(List<CellTrigger> trigger)
        {
            _triggers.AddRange(trigger);
        }

        public List<CellTrigger> GetTriggers(int cellId)
        {
            return _triggers.FindAll(x => x.Position.Cell.Id == cellId);
        }

        public List<CellTrigger> GetTriggers()
        {
            return _triggers;
        }

        public bool ExecuteTrigger(CellTriggerType triggerType, int cellId, Character character)
        {
            bool result = false;
            foreach (CellTrigger current in GetTriggers(cellId))
            {
                if (current.TriggerType == triggerType)
                {
                    current.Apply(character);
                    result = true;
                }
            }
            return result;
        }
        #endregion


        #region Get
        public GameRolePlayActorInformations[] GetActors()
        {
            return Clients.Select(x => x.Character.GetGameRolePlayCharacterInformations()).ToArray();
        }
        #endregion

        #region Sender
        public void Send(NetworkMessage msg)
        {
            foreach(var item in Clients)
                item.Send(msg);
        }
        #endregion

        #region Cells Functions
        public CellMap GetCellFree()
        {
            var cells = Cells.Where(x => x.Mov && !x.FarmCell);
            AsyncRandom asyncRandom = new AsyncRandom();
            var index = asyncRandom.Next(0, cells.Count() - 1);
            return cells.ElementAt(index);
        }

        public bool IsCellFree(short cell)
        {
            CellMap newCell = Cells.FirstOrDefault(x => x.Id == cell);
            return newCell != null ? newCell.Mov && !newCell.FarmCell : false;
        }

        public void MoveEntity(Client client, short[] cells)
        {
            foreach (var actor in Clients)
            {
                actor.Send(new GameMapMovementMessage(cells, client.Character.Infos.Id));
            }
        }
        #endregion
    }
}
