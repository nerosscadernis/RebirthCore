using Rebirth.Common.Dispatcher;
using Rebirth.Common.Protocol.Messages;
using Rebirth.World.Network;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Frames
{
    public class BasicFrame
    {
        [MessageHandler(BasicPingMessage.Id)]
        private void HandleBasicPingMessage(Client client, BasicPingMessage msg)
        {
            client.Send(new BasicPongMessage());
        }
    }
}
