using Rebirth.Common.Dispatcher;
using Rebirth.Common.Protocol.Messages;
using Rebirth.World.Datas.Clients;
using Rebirth.World.Managers;
using Rebirth.World.Network;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Frames
{
    public class AuthFrame
    {
        [MessageHandler(AccountInformationsMessage.Id)]
        private void HandleAccountInformationsMessage(Client client, AccountInformationsMessage msg)
        {
            AccountManager.Instance.UpdateAccount(new Account()
            {
                Id = msg.AccId,
                Key = msg.Key,
                Nickname = msg.Nickname,
                Role = msg.Role,
                SecretAnswer = msg.SecretAnswer,
                SecretQuestion = msg.SecretQuestion
            });
        }
    }
}
