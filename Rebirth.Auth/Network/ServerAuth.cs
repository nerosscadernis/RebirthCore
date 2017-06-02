using Rebirth.Auth.Datas;
using Rebirth.Common.Network;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Utils;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Rebirth.Auth.Network
{
    public class ServerAuth : ServerCore
    {
        public List<Client> Clients { get; set; }

        public ServerAuth(short port) : base(port)
        {
            Clients = new List<Client>();
        }

        public void SendServerUpdate(Server server)
        {
            foreach (var client in Clients.FindAll(x => x.Account != null))
            {
                client.Send(new ServerStatusUpdateMessage(server.GetGameServerInformations(client.Account.Id)));
            }
        }

        protected override void AcceptAsyncEvent_Completed(object sender, SocketAsyncEventArgs e)
        {
            Clients.Add(new Client(e.AcceptSocket));
            base.AcceptAsyncEvent_Completed(sender, e);
            Console.Title = "Clients = " + Clients.Count;
        }

        public void RemoveClient(Client client)
        {
            Clients.Remove(client);
            Console.Title = "Clients = " + Clients.Count;
        }
    }
}
