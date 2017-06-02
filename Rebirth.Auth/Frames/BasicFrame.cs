using Rebirth.Common.Dispatcher;
using Rebirth.Common.Network;
using Rebirth.Common.Protocol.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.Auth.Frames
{
    public class BasicFrame
    {
        [MessageHandler(BasicPingMessage.Id)]
        private void HandleBasicPingMessage(ClientCore client, BasicPingMessage msg)
        {
            client.Send(new BasicPongMessage());
        }
    }
}
