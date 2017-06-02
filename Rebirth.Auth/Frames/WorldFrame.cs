using Rebirth.Auth.Datas;
using Rebirth.Auth.Managers;
using Rebirth.Auth.Network;
using Rebirth.Common.Dispatcher;
using Rebirth.Common.Network;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.Auth.Frames
{
    public class WorldFrame
    {
        [MessageHandler(CreateCharacterMessage.Id)]
        private void HandleCreateCharacterMessage(WorldClient client, CreateCharacterMessage msg)
        {
            ServerManager.Instance.AddCharacter(msg.AccountId, (int)client.Server.Id);
        }

        [MessageHandler(DeleteCharacterMessage.Id)]
        private void HandleDeleteCharacterMessage(WorldClient client, DeleteCharacterMessage msg)
        {
            ServerManager.Instance.RemoveCharacter(msg.AccountId, (int)client.Server.Id);
        }

        [MessageHandler(UpdateStatuServerMessage.Id)]
        private void HandleUpdateStatuServerMessage(WorldClient client, UpdateStatuServerMessage msg)
        {
            if(client.Server != null)
            {
                client.Server.State = msg.state;
                Starter.Server.SendServerUpdate(client.Server);
            }
            else
            {
                Server server = ServerManager.Instance.GetServer(msg.serverId);
                if(server != null)
                {
                    server.State = msg.state;
                    client.Server = server;
                    Starter.Server.SendServerUpdate(server);
                }
            }
        }
    }
}
