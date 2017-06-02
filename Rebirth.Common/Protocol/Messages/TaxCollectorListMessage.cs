


















// Generated on 01/12/2017 03:53:01
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class TaxCollectorListMessage : AbstractTaxCollectorListMessage
{

public const uint Id = 5930;
public uint MessageId
{
    get { return Id; }
}

public sbyte nbcollectorMax;
        public Types.TaxCollectorFightersInformation[] fightersInformations;
        

public TaxCollectorListMessage()
{
}

public TaxCollectorListMessage(Types.TaxCollectorInformations[] informations, sbyte nbcollectorMax, Types.TaxCollectorFightersInformation[] fightersInformations)
         : base(informations)
        {
            this.nbcollectorMax = nbcollectorMax;
            this.fightersInformations = fightersInformations;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(nbcollectorMax);
            writer.WriteUShort((ushort)fightersInformations.Length);
            foreach (var entry in fightersInformations)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            nbcollectorMax = reader.ReadSByte();
            if (nbcollectorMax < 0)
                throw new System.Exception("Forbidden value on nbcollectorMax = " + nbcollectorMax + ", it doesn't respect the following condition : nbcollectorMax < 0");
            var limit = reader.ReadUShort();
            fightersInformations = new Types.TaxCollectorFightersInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 fightersInformations[i] = new Types.TaxCollectorFightersInformation();
                 fightersInformations[i].Deserialize(reader);
            }
            

}


}


}