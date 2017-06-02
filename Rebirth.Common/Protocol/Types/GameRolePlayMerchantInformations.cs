


















// Generated on 01/12/2017 03:53:07
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class GameRolePlayMerchantInformations : GameRolePlayNamedActorInformations
{

public const short Id = 129;
public override short TypeId
{
    get { return Id; }
}

public sbyte sellType;
        public Types.HumanOption[] options;
        

public GameRolePlayMerchantInformations()
{
}

public GameRolePlayMerchantInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, string name, sbyte sellType, Types.HumanOption[] options)
         : base(contextualId, look, disposition, name)
        {
            this.sellType = sellType;
            this.options = options;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(sellType);
            writer.WriteUShort((ushort)options.Length);
            foreach (var entry in options)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            sellType = reader.ReadSByte();
            if (sellType < 0)
                throw new System.Exception("Forbidden value on sellType = " + sellType + ", it doesn't respect the following condition : sellType < 0");
            var limit = reader.ReadUShort();
            options = new Types.HumanOption[limit];
            for (int i = 0; i < limit; i++)
            {
                 options[i] = ProtocolTypeManager.GetInstance<Types.HumanOption>(reader.ReadShort());
                 options[i].Deserialize(reader);
            }
            

}


}


}