using Rebirth.Common.Network;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Rebirth.Common.Dispatcher
{
    public class MethodHandler
    {
        public MethodInfo Method { get; private set; }
        public object Instance { get; private set; }
        public MessageHandlerAttribute[] Attributes { get; private set; }

        public MethodHandler(MethodInfo method, object instance, MessageHandlerAttribute[] attributes)
        {
            Method = method;
            Instance = instance;
            Attributes = attributes;
        }

        public void Invoke(NetworkMessage message, ClientCore client)
        {
            Method.Invoke(Instance, new object[] { client, message });
        }
    }
}
