using Rebirth.Common.Dispatcher;
using Rebirth.Common.Extensions;
using Rebirth.Common.IO;
using Rebirth.Common.Network;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Utils;
using Rebirth.World.Datas.Characters;
using Rebirth.World.Datas.Clients;
using Rebirth.World.Frames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Rebirth.World.Network
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
        public Character Character { get; set; }
        #endregion

        #region Constructor
        public Client(Socket socket) : base(socket)
        {
            dispatcher = new DispatcherCore(this);

            Disconnected += Disconnect;

            Register(typeof(IdentificationFrame));
            Register(typeof(BasicFrame));

            Send(new HelloGameMessage());
        }

        public Client(string ip, short port) : base(ip, port)
        {
            dispatcher = new DispatcherCore(this);

            Register(typeof(AuthFrame));

            Disconnected += Disconnect;
        }
        #endregion

        #region Event
        protected override void e_Completed(object sender, SocketAsyncEventArgs e)
        {
            base.e_Completed(sender, e);
        }

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
            if(Character != null)
            {
                Starter.Database.Update(Character.GetRecord());
                //Disconnect Function
                _logger.Infos(string.Format("Name : '{0}' disconnected !", Character.Infos.Name));
            }
            else if (Account != null)
                _logger.Infos(string.Format("NickName : '{0}' disconnected !", Account.Nickname));
            else
                _logger.Infos(string.Format("IP : '{0}' disconnected !", (Socket.RemoteEndPoint as IPEndPoint).Address));
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
    }
}
