


















// Generated on 01/12/2017 03:53:08
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Types
{

public class HumanOptionTitle : HumanOption
{

public const short Id = 408;
public override short TypeId
{
    get { return Id; }
}

public uint titleId;
        public string titleParam;
        

public HumanOptionTitle()
{
}

public HumanOptionTitle(uint titleId, string titleParam)
        {
            this.titleId = titleId;
            this.titleParam = titleParam;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)titleId);
            writer.WriteUTF(titleParam);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            titleId = reader.ReadVarUhShort();
            if (titleId < 0)
                throw new System.Exception("Forbidden value on titleId = " + titleId + ", it doesn't respect the following condition : titleId < 0");
            titleParam = reader.ReadUTF();
            

}


}


}