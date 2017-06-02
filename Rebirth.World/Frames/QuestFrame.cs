using Rebirth.Common.Dispatcher;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Network;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Frames
{
    public class QuestFrame
    {
        [MessageHandler(QuestListRequestMessage.Id)]
        public void HandleQuestListRequestMessage(Client client, QuestListRequestMessage message)
        {
            client.Send(new QuestListMessage(new uint[0], new uint[0], new QuestActiveInformations[0], new uint[0]));
        }
    }
}
