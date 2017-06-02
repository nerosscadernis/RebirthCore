using Rebirth.Common.Protocol.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.Common.IStructures
{
    public interface IActivity
    {
        DialogTypeEnum DialogType
        {
            get;
        }
        void Close();
    }
}
