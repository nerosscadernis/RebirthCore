using Rebirth.Common.Network;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Rebirth.World.Network
{
    public class WorldServer : ServerCore
    {
        public List<Client> Clients { get; set; }

        public WorldServer(short port) : base(port)
        {
            Clients = new List<Client>();
        }

        protected override void AcceptAsyncEvent_Completed(object sender, SocketAsyncEventArgs e)
        {
            var newClient = new Client(e.AcceptSocket);
            Clients.Add(newClient);
            base.AcceptAsyncEvent_Completed(sender, e);
        }

        public void RemoveClient(Client client)
        {
            Clients.Remove(client);
        }
    }
}
