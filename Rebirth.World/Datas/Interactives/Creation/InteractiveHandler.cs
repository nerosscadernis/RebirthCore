using Rebirth.World.Datas.Maps;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Rebirth.World.Datas.Interactives.Creation
{
    public class InteractiveHandler
    {
        public MethodInfo Method { get; private set; }
        public object Instance { get; private set; }
        public InteractiveAttribute[] Attributes { get; private set; }

        public InteractiveHandler(MethodInfo method, object instance, InteractiveAttribute[] attributes)
        {
            Method = method;
            Instance = instance;
            Attributes = attributes;
        }

        public void Invoke(MapTemplate map, int identifier, uint cellid, bool onMap, int subArea)
        {
            Method.Invoke(Instance, new object[] { map, identifier, cellid, onMap, subArea });
        }
    }
}
