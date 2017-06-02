


















// Generated on 01/12/2017 03:52:55
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class ShowCellSpectatorMessage : ShowCellMessage
{

public const uint Id = 6158;
public uint MessageId
{
    get { return Id; }
}

public string playerName;
        

public ShowCellSpectatorMessage()
{
}

public ShowCellSpectatorMessage(double sourceId, uint cellId, string playerName)
         : base(sourceId, cellId)
        {
            this.playerName = playerName;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(playerName);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            playerName = reader.ReadUTF();
            

}


}


}