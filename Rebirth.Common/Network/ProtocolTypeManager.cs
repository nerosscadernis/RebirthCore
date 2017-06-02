using Rebirth.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.Common.Network
{
    public static class ProtocolTypeManager
    {

        private static readonly Dictionary<short, Type> types = new Dictionary<short, Type>(200);
        private static readonly Dictionary<short, Func<object>> typesConstructors = new Dictionary<short, Func<object>>(200);
        public static void Initialize()
        {
            Assembly asm = typeof(ProtocolTypeManager).GetTypeInfo().Assembly;

            foreach (Type type in asm.GetTypes())
            {
                if (type.Namespace == null || !type.Namespace.Contains("Protocol.Types"))
                    continue;

                FieldInfo field = type.GetField("Id");

                if (field != null)
                {
                    // le cast uint est obligatoire car l'objet n'a pas de type
                    short id = (short)(field.GetValue(type));

                    types.Add(id, type);

                    ConstructorInfo ctor = type.GetConstructor(Type.EmptyTypes);

                    if (ctor == null)
                        throw new System.Exception(string.Format("'{0}' doesn't implemented a parameterless constructor", type));

                    typesConstructors.Add(id, ctor.CreateDelegate<Func<object>>());
                }
            }
        }

        public static T GetInstance<T>(short id) where T : class
        {
            if (!types.ContainsKey((short)id))
            {
                Console.WriteLine(string.Format("Type <id:{0}> doesn't exist", id));
            }

            return typesConstructors[(short)id]() as T;
        }

        
        public class ProtocolTypeNotFoundException : System.Exception
        {
            public ProtocolTypeNotFoundException()
            {
            }

            public ProtocolTypeNotFoundException(string message)
                : base(message)
            {
            }

            public ProtocolTypeNotFoundException(string message, System.Exception inner)
                : base(message, inner)
            {
            }
        }

    }
}
