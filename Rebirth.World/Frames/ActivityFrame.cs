using Rebirth.Common.Dispatcher;
using Rebirth.Common.Protocol.Messages;
using Rebirth.World.Network;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Frames
{
    public class ActivityFrame
    {
        [MessageHandler(LeaveDialogRequestMessage.Id)]
        private void HandleLeaveDialogRequestMessage(Client client, LeaveDialogRequestMessage message)
        {
            var activity = client.Character.Activity;
            if (activity != null)
                activity.Close();
        }
    }
}
