using Rebirth.Common.IStructures;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Timers;
using Rebirth.World.Datas.Characters;
using Rebirth.World.Datas.Maps;
using Rebirth.World.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rebirth.World.Datas.Interactives.Types
{
    public class Ressource : AbstractInteractive, IStatedElement
    {
        public uint[] ActionId
        {
            get;
        }
        public uint CellId
        {
            get;
            set;
        }
        public int Identifier
        {
            get;
            set;
        }
        public int Type
        {
            get;
        }
        public int ItemId
        {
            get;
        }
        public uint State
        {
            get;
            set;
        }
        public int MapId
        {
            get;
            set;
        }

        public short Age
        {
            get;
            set;
        }
        public bool IsOnMap
        {
            get;
            set;
        }

        public InteractiveElement GetInteractiveElement(Character character)
        {
            //if (State == 0)
            //    return new InteractiveElementWithAgeBonus(Identifier, Type, (from x in ActionId
            //                                                                 where character.Jobs.ContainsSkill(x) || x == 102
            //                                                                 select new InteractiveElementSkill(x, 0)).ToArray(), (from x in ActionId
            //                                                                                                                       where !character.Jobs.ContainsSkill(x) && x != 102
            //                                                                                                                       select new InteractiveElementSkill(x, 0)).ToArray(), IsOnMap, Age);
            //else
                return new InteractiveElement(Identifier, Type, new InteractiveElementSkill[0], (from x in ActionId
                                                                                                 select new InteractiveElementSkill(x, 0)).ToArray(), IsOnMap);
        }

        public StatedElement GetStatedElement()
        {
            return new StatedElement(Identifier, CellId, State, true);
        }

        public bool Used;
        public Character CharacterUser;

        TimerCore ageTimer;

        public Ressource(int Identifier, uint CellId, int Type, uint[] ActionId, int MapId, bool onMap)
        {
            //ageTimer = WorldServer.Instance.Pool.CallPeriodically(1000, new Action(TickRefresh));
            this.Age = 200;
            this.Identifier = Identifier;
            this.CellId = CellId;
            this.Type = Type;
            this.ActionId = ActionId;
            this.MapId = MapId;
            IsOnMap = onMap;
        }

        public void Use(Character character, uint skill)
        {
            //if (!Used)
            //{
            //    if (character.Jobs.ContainsSkill(ActionId[0]) || ActionId[0] == 102)
            //    {
            //        MapTemplate map = MapManager.Instance.GetMapById(MapId);
            //        if (map != null)
            //        {
            //            Used = true;
            //            map.Send(new InteractiveUsedMessage((uint)character.Id, (uint)Identifier, ActionId[0], 30, false));
            //            WorldServer.Instance.Pool.CallDelayed(3000, new Action(TickAction));
            //            CharacterUser = character;
            //        }
            //    }
            //    else
            //    {
            //        character.Client.Send(new InteractiveUseErrorMessage((uint)Identifier, ActionId[0]));
            //    }
            //}
            //else
            //{
                character.Client.Send(new InteractiveUseErrorMessage((uint)Identifier, ActionId[0]));
            //}
        }

        //public void TickAction()
        //{
        //    State = 1;
        //    MapTemplate map = MapManager.Instance.GetMap(MapId);
        //    if (map != null)
        //    {
        //        map.UpdateInteractive(this);
        //        map.Send(new InteractiveUseEndedMessage((uint)Identifier, ActionId[0]));
        //    }
        //    timer(30000, new Action(TickRespawn));
        //    WorldServer.Instance.Pool.CancelSimpleTimer(ageTimer);

        //    if (ActionId[0] != 102)
        //    {
        //        CharacterUser.Jobs.Recolte(ActionId[0], Age);
        //    }
        //    else
        //    {
        //        Common.Protocol.Data.Item item = ItemManager.Instance.GetItemTemplateById(311);
        //        int rdn = new Random().Next(1, 20);
        //        CharacterUser.Inventory.AddItem(ItemManager.Instance.CreatePlayerItem(CharacterUser, item, rdn));
        //        CharacterUser.Client.Send(new ObtainedItemMessage((uint)item.id, (uint)rdn));
        //    }
        //    Age = 0;
        //}

        //public void TickRespawn()
        //{
        //    Used = false;
        //    State = 0;
        //    MapTemplate map = MapManager.Instance.GetMapById(MapId);
        //    if (map != null)
        //    {
        //        map.UpdateInteractive(this);
        //    }
        //    ageTimer = WorldServer.Instance.Pool.CallPeriodically(120000, new Action(TickRefresh));
        //}

        //public void TickRefresh()
        //{
        //    Age += 20;
        //    if (Age == 200)
        //        WorldServer.Instance.Pool.CancelSimpleTimer(ageTimer);
        //}
    }
}
