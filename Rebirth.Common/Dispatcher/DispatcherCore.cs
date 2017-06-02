using Rebirth.Common.Network;
using Rebirth.Common.Timers;
using Rebirth.Common.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.Common.Dispatcher
{
    public class DispatcherCore
    {
        #region Var
        private Dictionary<uint, MethodHandler> methods;
        private Queue<NetworkMessage> msgQueue;
        private Task executionTask;
        private TimerCore timer;
        private ClientCore client;
        private Logger _logger;
        #endregion

        #region Constructor
        public DispatcherCore(ClientCore client)
        {
            this.client = client;
            _logger = LogManager.GetLoggerClass();
            methods = new Dictionary<uint, MethodHandler>();
            msgQueue = new Queue<NetworkMessage>();
            timer = new TimerCore(new Action(Execute), 50, 50);
        }
        #endregion

        #region Private Methods
        private void Execute()
        {
            if ((executionTask != null && !executionTask.IsCompleted) || msgQueue.Count <= 0)
                return; 
            var actualMessage = msgQueue.Dequeue();
            if(methods.ContainsKey(actualMessage.MessageId))
            {
                executionTask = Task.Run(() =>
                {
                    methods[actualMessage.MessageId].Invoke(actualMessage, client);
                });
            }
            else
            {
                executionTask = Task.Run(() =>
                {
                    _logger.Error(string.Format("Unknow treatment for : {0}", actualMessage.ToString().Split('.').Last()));
                });
            }
        }
        #endregion

        #region Public Methods
        public void RegisterFrame(Type type)
        {
            object obj = Activator.CreateInstance(type);
            foreach (var methodInfo in type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy))
            {
                MessageHandlerAttribute[] attributes = methodInfo.GetCustomAttributes<MessageHandlerAttribute>().ToArray();
                if (attributes.Length != 0)
                {
                    ParameterInfo[] parameters = methodInfo.GetParameters();
                    if (parameters.Length != 2)
                    {
                        throw new Exception(string.Format("Only two parameters is allowed to use the MessageHandler attribute. (method {0})", methodInfo.Name));
                    }

                    methods.Add(attributes.First().MessageId, new MethodHandler(methodInfo, obj, attributes));
                }
            }
        }

        public void UnRegisterFrame(Type type)
        {
            object obj = Activator.CreateInstance(type);
            foreach (var methodInfo in type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy))
            {
                MessageHandlerAttribute[] attributes = methodInfo.GetCustomAttributes<MessageHandlerAttribute>().ToArray();
                if (attributes.Length != 0)
                {
                    ParameterInfo[] parameters = methodInfo.GetParameters();
                    if (parameters.Length != 2)
                    {
                        throw new Exception(string.Format("Only two parameters is allowed to use the MessageHandler attribute. (method {0})", methodInfo.Name));
                    }

                    methods.Remove(attributes.First().MessageId);
                }
            }
        }

        public void Dispatch(NetworkMessage msg)
        {
            msgQueue.Enqueue(msg);
        }
        #endregion
    }
}
