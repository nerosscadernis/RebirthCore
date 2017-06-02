﻿using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Rebirth.Common.Extensions
{
    public static class SocketExtensions
    {
        public static bool IsConnected(this Socket socket)
        {
            try
            {
                return !(socket.Poll(1, SelectMode.SelectRead) && socket.Available == 0);
            }
            catch (Exception)
            { return false; }
        }
    }
}
