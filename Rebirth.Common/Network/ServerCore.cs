using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.Common.Network
{
    public class ServerCore : IDisposable
    {
        #region Var
        protected Socket socket;
        private IPEndPoint localEndPoint;
        #endregion

        #region Event
        protected SocketAsyncEventArgs AcceptAsyncEvent;
        #endregion

        #region Constructor
        public ServerCore()
        { }

        public ServerCore(short port)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            AcceptAsyncEvent = new SocketAsyncEventArgs();
            AcceptAsyncEvent.Completed += AcceptAsyncEvent_Completed;

            Start(port);
        }
        #endregion

        #region Public Methods
        public void Start(short port)
        {
            localEndPoint = new IPEndPoint(IPAddress.Loopback, port);
            socket.Bind(localEndPoint);
            socket.Listen(100);
            BeginAccept();
        }

        public void Dispose()
        {
            socket.Dispose();
        }
        #endregion

        #region Private Methods
        protected void BeginAccept()
        {
            try
            {
                AcceptAsyncEvent = new SocketAsyncEventArgs();
                AcceptAsyncEvent.Completed += AcceptAsyncEvent_Completed;
                socket.AcceptAsync(AcceptAsyncEvent);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected virtual void AcceptAsyncEvent_Completed(object sender, SocketAsyncEventArgs e)
        {
            Socket listenSocket = (Socket)sender;
            do
            {
                e.AcceptSocket = null;
            } while (!listenSocket.AcceptAsync(e));
        }
        #endregion
    }
}
