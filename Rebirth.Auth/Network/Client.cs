using Rebirth.Auth.Datas;
using Rebirth.Auth.Frames;
using Rebirth.Common.Dispatcher;
using Rebirth.Common.Extensions;
using Rebirth.Common.IO;
using Rebirth.Common.Network;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Rebirth.Auth.Network
{
    public class Client : ClientCore
    {
        #region Var
        MessagePart currentMessage;
        DispatcherCore dispatcher;
        private Logger _logger = LogManager.GetLoggerClass();
        #endregion

        #region Properties
        public Account Account { get; set; }
        public byte[] Aes { get; set; }
        #endregion

        #region Constructor
        public Client(Socket socket) : base(socket)
        {
            dispatcher = new DispatcherCore(this);
            dispatcher.RegisterFrame(typeof(BasicFrame));
            dispatcher.RegisterFrame(typeof(IdentificationFrame));

            Disconnected += Disconnect;
            
            Send(new ProtocolRequired(1758, 1759));
            Send(new RawDataMessage(File.ReadAllBytes(".\\RawDataMessage.swf")));
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
            Starter.Server.RemoveClient(this);
        }

        public static byte[] StringToByteArray(string hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
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

        public void Register(Type type)
        {
            dispatcher.RegisterFrame(type);
        }
        public void UnRegister(Type type)
        {
            dispatcher.UnRegisterFrame(type);
        }

        #endregion

        public override void Dispose()
        {
            dispatcher = null;
            currentMessage = null;
            Account = null;
            base.Dispose();
        }
    }
}
