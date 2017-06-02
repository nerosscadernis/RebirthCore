using Rebirth.Auth.Datas;
using Rebirth.Auth.Frames;
using Rebirth.Auth.Managers;
using Rebirth.Auth.Network;
using Rebirth.Common.Extensions;
using Rebirth.Common.Network;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Timers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.Auth
{
    public class IdentificationTreatment
    {
        #region Var
        private Queue<Tuple<IdentificationMessage, Client>> _queue;
        private Task _actualTask;
        private Task _refreshTask;
        private TimerCore _timer;
        private TimerCore _refreshTimer;
        private object _locker = new object();
        #endregion

        #region Constructor
        public IdentificationTreatment()
        {
            _queue = new Queue<Tuple<IdentificationMessage, Client>>();
            _timer = new TimerCore(new Action(TaskExecut), 50, 50);
            _refreshTimer = new TimerCore(new Action(Refresh), 500, 500);
        }
        #endregion

        #region Private Methods
        private void Refresh()
        {
            if (_refreshTask != null && !_refreshTask.IsCompleted)
                return;

            _refreshTask = Task.Run(() =>
            {
                lock(_locker)
                {
                    ushort i = 1;
                    foreach (var item in _queue)
                    {
                        item.Item2.Send(new LoginQueueStatusMessage(i, (ushort)_queue.Count));
                        i++;
                    }
                }
            });
        }

        private void TaskExecut()
        {
            if ((_actualTask != null && !_actualTask.IsCompleted) || _queue.Count <= 0)
                return;

            _actualTask = Task.Run(() =>
            {
                lock(_locker)
                {
                    Treatment();
                }
            });
        }

        private void Treatment()
        { 
            var infos = _queue.Dequeue();
            infos.Item2.Send(new LoginQueueStatusMessage(0, 0));
            InitCredentials(infos.Item1.credentials);

            string login = ReadUtfCredentials();
            string pass = ReadUtfCredentials();

            if (login.Length >= 0 || pass.Length >= 0)
            {
                var account = Starter.Database.Single<Account>("SELECT * FROM accounts WHERE Login='" + login + "'");
                if(account != null)
                {
                    if(pass.GetMD5() == account.Password)
                    {
                        switch (account.Role)
                        {
                            case CharacterRoleEnum.Banned:
                                infos.Item2.Send(new IdentificationFailedMessage((sbyte)IdentificationFailureReasonEnum.BANNED));
                                break;
                            case CharacterRoleEnum.Player:
                                SuccesIdentification(infos.Item2, account, false);
                                break;
                            case CharacterRoleEnum.Animator:
                            case CharacterRoleEnum.Moderator:
                            case CharacterRoleEnum.Administrator:
                                SuccesIdentification(infos.Item2, account, true);
                                break;
                            default:
                                infos.Item2.Send(new IdentificationFailedMessage((sbyte)IdentificationFailureReasonEnum.UNKNOWN_AUTH_ERROR));
                                break;
                        }
                    }
                    else
                        infos.Item2.Send(new IdentificationFailedMessage((sbyte)IdentificationFailureReasonEnum.WRONG_CREDENTIALS));
                }
                else
                    infos.Item2.Send(new IdentificationFailedMessage((sbyte)IdentificationFailureReasonEnum.WRONG_CREDENTIALS));
            }
            else
                infos.Item2.Send(new IdentificationFailedMessage((sbyte)IdentificationFailureReasonEnum.WRONG_CREDENTIALS));
        }

        private void SuccesIdentification(Client client, Account account, bool hasRight)
        {

            try
            {
                client.Aes = ReadAes();
                client.Account = account;

                var endDate = 1577748077000;
                var date = DateTime.Now.DateTimeToUnixTimestamp();

                client.Register(typeof(ServerFrame));

                client.Send(new IdentificationSuccessMessage(hasRight, false, account.Login, account.Nickname, account.Id, 0, account.SecretQuestion, 0, endDate - date, endDate, 0));
                client.Send(new ServersListMessage(ServerManager.Instance.GetListInformation(account.Id), 0, true));
            }
            catch (Exception ex)
            {
                // TODO Logger.Error("[IdentificationTrreatment.SuccesIdentification] {0}", ex.InnerException)
                throw;
            }
        }
        #endregion

        #region Public Methods
        public void Enter(Client client, IdentificationMessage msg)
        {
            _queue.Enqueue(new Tuple<IdentificationMessage, Client>(msg, client));
            client.Send(new LoginQueueStatusMessage(0, (ushort)_queue.Count));
            client.UnRegister(typeof(IdentificationFrame));
        }
        #endregion

        #region Credentials
        private BinaryReader _credentialsReader;

        public void InitCredentials(byte[] datas)
        {
            _credentialsReader = new BinaryReader(new MemoryStream(datas), Encoding.UTF8);
        }

        private string ReadUtfCredentials()
        {
            ushort length = ReadUShortCredentials();
            byte[] bytes = _credentialsReader.ReadBytes(length);
            return Encoding.UTF8.GetString(bytes);
        }

        private byte[] ReadAes()
        {
            return _credentialsReader.ReadBytes(32);
        }

        private ushort ReadUShortCredentials()
        {
            return (ushort)((Convert.ToUInt16(_credentialsReader.ReadByte()) << 8) + _credentialsReader.ReadByte());
        }
        #endregion
    }
}
