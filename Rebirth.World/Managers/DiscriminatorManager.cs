using Rebirth.Common.Extensions;
using Rebirth.World.Datas.Bdd;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Rebirth.World.Managers
{
    public class DiscriminatorManager<T> : DataManager<DiscriminatorManager<T>>
    {
        private bool m_initialized;
        private Dictionary<string, Delegate> m_constructors = new Dictionary<string, Delegate>();

        public void Initialize(Assembly assembly)
        {
            if (assembly == null)
            {
                throw new ArgumentNullException("assembly");
            }
            Type[] types = assembly.GetTypes();
            for (int i = 0; i < types.Length; i++)
            {
                Type type = types[i];
                DiscriminatorAttribute customAttribute = type.GetTypeInfo().GetCustomAttribute<DiscriminatorAttribute>();
                if (customAttribute != null)
                {
                    Type baseType = customAttribute.BaseType;
                    if (!(baseType != typeof(T)))
                    {
                        Delegate value = type.GetConstructor(customAttribute.CtorParameters).CreateDelegate();
                        this.m_constructors.Add(customAttribute.Discriminator, value);
                    }
                }
            }
            this.m_initialized = true;
        }
        private void CheckBeforeGenerate(string discriminator, Assembly assembly)
        {
            if (!this.m_initialized)
            {
                this.Initialize(assembly);
            }
            if (!this.m_constructors.ContainsKey(discriminator))
            {
                throw new Exception(string.Format("Type bound to discriminator '{0}' not found ({1})", discriminator, typeof(T)));
            }
        }
        public T Generate<TArg>(string discriminator, TArg parameter)
        {
            this.CheckBeforeGenerate(discriminator, typeof(T).GetTypeInfo().Assembly);
            return ((Func<TArg, T>)this.m_constructors[discriminator])(parameter);
        }
        public T Generate<TArg1, TArg2>(string discriminator, TArg1 parameter1, TArg2 parameter2)
        {
            this.CheckBeforeGenerate(discriminator, typeof(T).GetTypeInfo().Assembly);
            return ((Func<TArg1, TArg2, T>)this.m_constructors[discriminator])(parameter1, parameter2);
        }
        public T Generate<TArg1, TArg2, TArg3>(string discriminator, TArg1 parameter1, TArg2 parameter2, TArg3 parameter3)
        {
            this.CheckBeforeGenerate(discriminator, typeof(T).GetTypeInfo().Assembly);
            return ((Func<TArg1, TArg2, TArg3, T>)this.m_constructors[discriminator])(parameter1, parameter2, parameter3);
        }
        public T Generate<TArg1, TArg2, TArg3, TArg4>(string discriminator, TArg1 parameter1, TArg2 parameter2, TArg3 parameter3, TArg4 parameter4)
        {
            this.CheckBeforeGenerate(discriminator, typeof(T).GetTypeInfo().Assembly);
            return ((Func<TArg1, TArg2, TArg3, TArg4, T>)this.m_constructors[discriminator])(parameter1, parameter2, parameter3, parameter4);
        }
    }
}
