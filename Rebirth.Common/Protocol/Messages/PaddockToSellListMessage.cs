


















// Generated on 01/12/2017 03:52:58
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class PaddockToSellListMessage : NetworkMessage
{

public const uint Id = 6138;
public uint MessageId
{
    get { return Id; }
}

public uint pageIndex;
        public uint totalPage;
        public Types.PaddockInformationsForSell[] paddockList;
        

public PaddockToSellListMessage()
{
}

public PaddockToSellListMessage(uint pageIndex, uint totalPage, Types.PaddockInformationsForSell[] paddockList)
        {
            this.pageIndex = pageIndex;
            this.totalPage = totalPage;
            this.paddockList = paddockList;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)pageIndex);
            writer.WriteVarShort((int)totalPage);
            writer.WriteUShort((ushort)paddockList.Length);
            foreach (var entry in paddockList)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

pageIndex = reader.ReadVarUhShort();
            if (pageIndex < 0)
                throw new System.Exception("Forbidden value on pageIndex = " + pageIndex + ", it doesn't respect the following condition : pageIndex < 0");
            totalPage = reader.ReadVarUhShort();
            if (totalPage < 0)
                throw new System.Exception("Forbidden value on totalPage = " + totalPage + ", it doesn't respect the following condition : totalPage < 0");
            var limit = reader.ReadUShort();
            paddockList = new Types.PaddockInformationsForSell[limit];
            for (int i = 0; i < limit; i++)
            {
                 paddockList[i] = new Types.PaddockInformationsForSell();
                 paddockList[i].Deserialize(reader);
            }
            

}


}


}