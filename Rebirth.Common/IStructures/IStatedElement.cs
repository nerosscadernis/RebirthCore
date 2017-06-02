using Rebirth.Common.Protocol.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.Common.IStructures
{
    public interface IStatedElement
    {
        uint State { get; set; }
        StatedElement GetStatedElement();
    }
}
