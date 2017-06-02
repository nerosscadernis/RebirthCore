using Rebirth.Auth.Datas;
using Rebirth.Auth.Managers;
using Rebirth.Auth.Network;
using Rebirth.Common.Crypto;
using Rebirth.Common.Dispatcher;
using Rebirth.Common.IO;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Random;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Rebirth.Auth.Frames
{
    public class ServerFrame
    {
        [MessageHandler(ServerSelectionMessage.Id)]
        private void HandleServerSelectionMessage(Client client, ServerSelectionMessage msg)
        {
            Server server = ServerManager.Instance.GetServer((int)msg.serverId);
            if (server != null && server.State == ServerStatusEnum.ONLINE)
            {
                string newTicket = StringGenerator.GetRandomString(32);

                var writer = new BigEndianWriter();
                writer.WriteUTF(newTicket);

                client.Account.Ticket = newTicket;

                Starter.WorldServer.SendTo((int)server.Id, new AccountInformationsMessage()
                {
                    AccId = client.Account.Id,
                    Key = newTicket,
                    Nickname = client.Account.Nickname,
                    Role = client.Account.Role,
                    SecretAnswer = client.Account.SecretAnswer,
                    SecretQuestion = client.Account.SecretQuestion
                });
                client.Send(new SelectedServerDataMessage(server.Id, server.Ip, (ushort)server.Port, true, SimpleAES.EncryptAES(writer.Data, client.Aes).Select(i => (sbyte)i).ToArray()));
                Thread.Sleep(500);
                client.Dispose();
            }
        }

        [MessageHandler(AcquaintanceSearchMessage.Id)]
        private void HandleAcquaintanceSearchMessage(Client client, AcquaintanceSearchMessage msg)
        {
            Account acc = Starter.Database.Single<Account>("SELECT * FROM accounts WHERE nickname='" + msg.nickname + "'");
            if (acc != null)
            {
                uint[] servers = ServerManager.Instance.GetServerAccount(acc.Id);
                if(servers.Count() > 0)
                    client.Send(new AcquaintanceServerListMessage(servers));
                else
                    client.Send(new AcquaintanceSearchErrorMessage(2));
            }
            else
                client.Send(new AcquaintanceSearchErrorMessage(2));
        }
    }
}