


















// Generated on 01/12/2017 03:52:52
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class GameActionFightDispellEffectMessage : GameActionFightDispellMessage
{

public const uint Id = 6113;
public uint MessageId
{
    get { return Id; }
}

public int boostUID;
        

public GameActionFightDispellEffectMessage()
{
}

public GameActionFightDispellEffectMessage(uint actionId, double sourceId, double targetId, int boostUID)
         : base(actionId, sourceId, targetId)
        {
            this.boostUID = boostUID;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(boostUID);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            boostUID = reader.ReadInt();
            if (boostUID < 0)
                throw new System.Exception("Forbidden value on boostUID = " + boostUID + ", it doesn't respect the following condition : boostUID < 0");
            

}


}


}