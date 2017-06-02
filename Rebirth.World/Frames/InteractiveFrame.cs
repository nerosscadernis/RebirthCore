using Rebirth.Common.Dispatcher;
using Rebirth.Common.IStructures;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Messages;
using Rebirth.World.Datas.Interactives.Types;
using Rebirth.World.Datas.Maps;
using Rebirth.World.Managers;
using Rebirth.World.Network;
using Rebirth.World.Datas.Interactives.Dialogs;
using System;
using System.Collections.Generic;
using System.Text;
using Rebirth.World.Datas.Interactives.Types.Classic;

namespace Rebirth.World.Frames
{
    public class InteractiveFrame
    {
        [MessageHandler(InteractiveUseRequestMessage.Id)]
        private void HandleInteractiveUseRequestMessage(Client client, InteractiveUseRequestMessage message)
        {
            AbstractInteractive interact = client.Character.Map.GetInterctive((int)message.elemId);
            if (interact != null)
            {
                if (new MapPoint((short)client.Character.Infos.CellId).IsAdjacentTo(new MapPoint((short)interact.CellId), true))
                {
                    interact.Use(client.Character, message.skillInstanceUid);
                }
            }
        }

        [MessageHandler(TeleportRequestMessage.Id)]
        private void HandleTeleportRequestMessage(Client client, TeleportRequestMessage message)
        {
            if (client.Character.Activity != null && client.Character.Activity is ZaapDialog)
            {
                Waypoint wp = InteractiveManager.Instance.GetWaypointByMap(message.mapId);
                if (wp != null)
                {
                    MapTemplate newMap = MapManager.Instance.GetMap((int)wp.mapId);
                    InteractiveZaap newZaap = newMap.GetZaap() as InteractiveZaap;
                    if (newZaap != null)
                    {
                        uint cellId = (uint)(new MapPoint((short)newZaap.CellId).GetNearestCellInDirection(Common.Protocol.Enums.DirectionsEnum.DIRECTION_SOUTH_EAST).CellId);
                        if (!newMap.IsCellFree((short)cellId))
                        {
                            cellId = (uint)(new MapPoint((short)newZaap.CellId).GetNearestCellInDirection(Common.Protocol.Enums.DirectionsEnum.DIRECTION_SOUTH_WEST).CellId);
                        }
                        client.Character.Activity.Close();
                        client.Character.Teleport((int)wp.mapId, (short)cellId);
                    }
                }
            }
            else if (client.Character.Activity != null && client.Character.Activity is ZaapiDialog)
            {
                MapTemplate newMap = MapManager.Instance.GetMap(message.mapId);
                if (newMap == null)
                    return;
                if (!MapManager.Instance.HisGoodSub(client.Character.Map.SubArea, newMap.SubArea))
                    return;

                InteractiveZaapi newZaapi = newMap.GetZaapi() as InteractiveZaapi;
                if (newZaapi == null)
                    return;

                uint cellId = (uint)(new MapPoint((short)newZaapi.CellId).GetNearestCellInDirection(Common.Protocol.Enums.DirectionsEnum.DIRECTION_SOUTH_EAST).CellId);
                if (!newMap.IsCellFree((short)cellId))
                {
                    cellId = (uint)(new MapPoint((short)newZaapi.CellId).GetNearestCellInDirection(Common.Protocol.Enums.DirectionsEnum.DIRECTION_SOUTH_WEST).CellId);
                }
                client.Character.Activity.Close();
                client.Character.Teleport((int)newZaapi.MapId, (short)cellId);
            }
        }

        [MessageHandler(ZaapRespawnSaveRequestMessage.Id)]
        private void HandleZaapRespawnSaveRequestMessage(Client client, ZaapRespawnSaveRequestMessage message)
        {
            IActivity interact = client.Character.Activity;
            if (interact is ZaapDialog)
            {
                if (new MapPoint((short)client.Character.Infos.CellId).IsAdjacentTo(new MapPoint((short)(interact as ZaapDialog).Zaap.CellId), true))
                {
                    var waypoint = InteractiveManager.Instance.GetWaypointByMap(client.Character.Map.Id);
                    if (waypoint != null)
                    {
                        client.Character.Infos.ZaapSave = waypoint.mapId;
                        client.Send(new ZaapRespawnUpdatedMessage((int)waypoint.mapId));
                    }
                }
            }
        }

        public static void SendInteractiveUsedMessage(Client client, uint elemId, uint skillId, uint duration, bool canMove = false)
        {
            client.Send(new InteractiveUsedMessage((uint)client.Character.Infos.Id, elemId, skillId, duration, canMove));
        }
    }
}
