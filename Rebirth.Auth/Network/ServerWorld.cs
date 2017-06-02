using Rebirth.Common.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Rebirth.Auth.Network
{
    public class ServerWorld : ServerCore
    {
        public List<WorldClient> Clients { get; set; }

        public ServerWorld(short port) : base(port)
        {
            Clients = new List<WorldClient>();
        }

        protected override void AcceptAsyncEvent_Completed(object sender, SocketAsyncEventArgs e)
        {
            Clients.Add(new WorldClient(e.AcceptSocket));
            base.AcceptAsyncEvent_Completed(sender, e);
        }

        public void SendTo(int serverId, NetworkMessage msg)
        {
            var client = Clients.FirstOrDefault(x => x.Server != null && x.Server.Id == serverId);
            client?.Send(msg);
        }

        public void RemoveClient(WorldClient client)
        {
            Clients.Remove(client);
        }
    }
}
