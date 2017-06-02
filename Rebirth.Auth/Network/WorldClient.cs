using Rebirth.Auth.Datas;
using Rebirth.Auth.Frames;
using Rebirth.Common.Dispatcher;
using Rebirth.Common.Extensions;
using Rebirth.Common.IO;
using Rebirth.Common.Network;
using Rebirth.Common.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Rebirth.Auth.Network
{
    public class WorldClient : ClientCore
    {
        #region Var
        MessagePart currentMessage;
        DispatcherCore dispatcher;
        private Logger _logger = LogManager.GetLoggerClass();
        #endregion

        #region Properties
        public Server Server { get; set; }
        #endregion

        #region Constructor
        public WorldClient(Socket socket) : base(socket)
        {
            dispatcher = new DispatcherCore(this);
            dispatcher.RegisterFrame(typeof(WorldFrame));

            Disconnected += Disconnect;
        }
        #endregion

        #region Event
        protected override void ReceiveEvent_Completed(object sender, SocketAsyncEventArgs e)
        {
            if (!IsConnected())
                return;
            if (currentMessage == null)
                currentMessage = new MessagePart();
            var newBuffer = new BigEndianReader(buffer);
            if (currentMessage.Build(newBuffer))
            {
                var messageDataReader = new BigEndianReader(currentMessage.Data);
                NetworkMessage message = MessageReceiver.BuildMessage((uint)currentMessage.MessageId, messageDataReader);
                if (message == null)
                    return;
                dispatcher.Dispatch(message);
                _logger.Receive(message.ToString().Split('.').Last());
                currentMessage = null;
            }
            base.ReceiveEvent_Completed(sender, e);
        }

        private void Disconnect()
        {
            if (Server != null)
                Server.State = Common.Protocol.Enums.ServerStatusEnum.OFFLINE;
            Starter.WorldServer.RemoveClient(this);
        }
        #endregion

        #region Methods
        public void Send(NetworkMessage msg)
        {
            if (!IsConnected())
                return;

            var writer = new BigEndianWriter();
            MessagePacking pack = new MessagePacking();
            pack.Pack(msg, writer);
            _logger.Send(msg.ToString().Split('.').Last());
            Send(writer.Data);
        }
        #endregion
    }
}
