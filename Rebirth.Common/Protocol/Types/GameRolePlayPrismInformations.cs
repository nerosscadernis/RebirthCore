


















// Generated on 01/12/2017 03:53:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameRolePlayPrismInformations : GameRolePlayActorInformations
{

public const short Id = 161;
public override short TypeId
{
    get { return Id; }
}

public Types.PrismInformation prism;
        

public GameRolePlayPrismInformations()
{
}

public GameRolePlayPrismInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, Types.PrismInformation prism)
         : base(contextualId, look, disposition)
        {
            this.prism = prism;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(prism.TypeId);
            prism.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            prism = ProtocolTypeManager.GetInstance<Types.PrismInformation>(reader.ReadShort());
            prism.Deserialize(reader);
            

}


}


}