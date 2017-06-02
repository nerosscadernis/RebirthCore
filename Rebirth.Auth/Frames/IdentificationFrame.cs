using Rebirth.Auth.Network;
using Rebirth.Common.Dispatcher;
using Rebirth.Common.Protocol.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.Auth.Frames
{
    public class IdentificationFrame
    {
        [MessageHandler(IdentificationMessage.Id)]
        private void HandleIdentificationMessage(Client client, IdentificationMessage msg)
        {
            Starter.Identification.Enter(client, msg);
        }
    }
}
