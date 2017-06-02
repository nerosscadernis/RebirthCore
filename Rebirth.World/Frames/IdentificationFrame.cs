using Rebirth.World.Managers;
using Rebirth.World.Network;
using Rebirth.Common.Dispatcher;
using Rebirth.Common.Protocol.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Frames
{
    public class IdentificationFrame
    {
        [MessageHandler(AuthenticationTicketMessage.Id)]
        private void HandleAccountInformationsMessage(Client client, AuthenticationTicketMessage msg)
        {
            var acc = AccountManager.Instance.GetAccount(msg.ticket.Replace("\u000e", "").Replace("\0", "").Trim());
            if (acc != null)
            {
                client.Account = acc;

                client.UnRegister(typeof(IdentificationFrame));
                client.Register(typeof(CharacterFrame));

                client.Send(new AuthenticationTicketAcceptedMessage());
            }
            else
            {
                client.Send(new AuthenticationTicketRefusedMessage());
                client.Dispose();
            }
        }
    }
}
