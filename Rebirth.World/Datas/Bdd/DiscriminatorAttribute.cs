using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Bdd
{
    public class DiscriminatorAttribute : Attribute
    {
        public string Discriminator
        {
            get;
            set;
        }
        public Type BaseType
        {
            get;
            set;
        }
        public Type[] CtorParameters
        {
            get;
            set;
        }
        public DiscriminatorAttribute(string discriminator, Type baseType, params Type[] ctorParameters)
        {
            this.Discriminator = discriminator;
            this.BaseType = baseType;
            this.CtorParameters = ctorParameters;
        }
    }
}
