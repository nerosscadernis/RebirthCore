using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Interactives.Creation
{
    public class InteractiveAttribute : Attribute
    {
        public Type Type { get; private set; }
        public string Name { get; private set; }
        public InteractiveAttribute(Type type)
        {
            Type = type;
        }

        public InteractiveAttribute(string name)
        {
            Name = name;
        }
    }
}
