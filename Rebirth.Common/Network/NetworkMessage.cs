using Rebirth.Common.IO;
using System;

namespace Rebirth.Common.Network
{
    public interface NetworkMessage
    {
        uint MessageId { get; }
        void Serialize(IDataWriter writer);
        void Deserialize(IDataReader reader);
    }
}