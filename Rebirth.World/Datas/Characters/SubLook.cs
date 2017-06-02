using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Characters
{
    public class SubLook
    {
        private SubEntityBindingPointCategoryEnum m_bindingCategory;
        private sbyte m_bindingIndex;
        private Look m_look;
        public sbyte BindingIndex
        {
            get
            {
                return this.m_bindingIndex;
            }
            set
            {
                this.m_bindingIndex = value;
            }
        }
        public SubEntityBindingPointCategoryEnum BindingCategory
        {
            get
            {
                return this.m_bindingCategory;
            }
            set
            {
                this.m_bindingCategory = value;
            }
        }

        public SubLook(sbyte index, SubEntityBindingPointCategoryEnum category, Look look)
        {
            this.m_bindingIndex = index;
            this.m_bindingCategory = category;
            this.m_look = look;

        }
        public Look Look
        {
            get { return m_look; }
        }
        public override string ToString()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            stringBuilder.Append((sbyte)this.BindingCategory);
            stringBuilder.Append("@");
            stringBuilder.Append(this.BindingIndex);
            stringBuilder.Append("=");
            stringBuilder.Append(this.Look);
            return stringBuilder.ToString();
        }

        public SubEntity GetSubEntity()
        {
            return new SubEntity((sbyte)BindingCategory, (sbyte)BindingIndex, Look.GetEntityLook());
        }
    }
}
