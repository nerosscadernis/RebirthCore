using Rebirth.Common.Extensions;
using Rebirth.Common.IO;
using Rebirth.Common.Timers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.Common.Network
{
    public class ClientCore : IDisposable
    {
        #region MyRegion
        const int bufferLength = 8192;

        public byte[] buffer = new byte[bufferLength];
        public Socket Socket;

        protected SocketAsyncEventArgs ReceiveEvent;
        protected event Action Disconnected;

        private TimerCore _timer;
        private object _sender;
        #endregion

        #region Constructor
        public ClientCore(Socket socket)
        {
            _sender = new object();
            Socket = socket;
            socket.NoDelay = true;

            ReceiveEvent = new SocketAsyncEventArgs();
            ReceiveEvent.SetBuffer(buffer, 0, buffer.Length);
            ReceiveEvent.Completed += ReceiveEvent_Completed;

            _timer = new TimerCore(new Action(CheckDisonnect), 50, 50);

            if(!Socket.ReceiveAsync(ReceiveEvent))
            {
                ReceiveEvent_Completed(Socket, ReceiveEvent);
            }
        }

        public ClientCore(string ip, short port)
        {
            _sender = new object();
            Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            SocketAsyncEventArgs e = new SocketAsyncEventArgs();
            e.RemoteEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            e.UserToken = Socket;
            e.Completed += new EventHandler<SocketAsyncEventArgs>(e_Completed);
            Socket.ConnectAsync(e);
        }

        protected virtual void e_Completed(object sender, SocketAsyncEventArgs e)
        {
            ReceiveEvent = new SocketAsyncEventArgs();
            ReceiveEvent.SetBuffer(buffer, 0, buffer.Length);
            ReceiveEvent.Completed += ReceiveEvent_Completed;

            _timer = new TimerCore(new Action(CheckDisonnect), 50, 50);

            if (!Socket.ReceiveAsync(ReceiveEvent))
            {
                ReceiveEvent_Completed(Socket, ReceiveEvent);
            }
        }

        #endregion

        #region Event
        protected virtual void ReceiveEvent_Completed(object sender, SocketAsyncEventArgs e)
        {
            do
            {
                if (!IsConnected())
                    break;
            } while (!Socket.ReceiveAsync(ReceiveEvent));
        }

        protected virtual void DisconnectedEvent()
        {
            Disconnected?.Invoke();
            _timer.Dispose();
        }
        #endregion

        #region Funcs
        public void Send(NetworkMessage msg)
        {
            if (!IsConnected())
                return;

            var writer = new BigEndianWriter();
            MessagePacking pack = new MessagePacking();
            pack.Pack(msg, writer);
            Console.WriteLine("Send = {0}", msg.ToString().Split('.').Last());
            
            lock (_sender)
            {
                Socket.Send(writer.Data);
            }
        }

        public void Send(byte[] datas)
        {
            if (!IsConnected())
                return;

            lock (_sender)
            {
                Socket.Send(datas);
            }
        }

        public virtual void Dispose()
        {
            Socket.Dispose();
            Socket = null;
            buffer = null;
            _timer.Dispose();
            Disconnected?.Invoke();
        }

        private void CheckDisonnect()
        {
            if (!IsConnected())
                DisconnectedEvent();
        }

        public bool IsConnected()
        {
            if (Socket == null)
                return false;
            else
                return Socket.IsConnected();
        }
        #endregion
    }
}
