using Rebirth.Common.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.Common.Network
{
    public interface NetworkType
    {
        short TypeId { get; }
        void Serialize(IDataWriter writer);
        void Deserialize(IDataReader reader);
    }
}
