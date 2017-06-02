


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Network;
using Rebirth.Common.IO;

namespace Rebirth.Common.Protocol.Messages
{

public class HavenBagFurnituresRequestMessage : NetworkMessage
{

public const uint Id = 6637;
public uint MessageId
{
    get { return Id; }
}

public uint[] cellIds;
        public int[] funitureIds;
        public sbyte[] orientations;
        

public HavenBagFurnituresRequestMessage()
{
}

public HavenBagFurnituresRequestMessage(uint[] cellIds, int[] funitureIds, sbyte[] orientations)
        {
            this.cellIds = cellIds;
            this.funitureIds = funitureIds;
            this.orientations = orientations;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)cellIds.Length);
            foreach (var entry in cellIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteUShort((ushort)funitureIds.Length);
            foreach (var entry in funitureIds)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteUShort((ushort)orientations.Length);
            foreach (var entry in orientations)
            {
                 writer.WriteSByte(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            cellIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 cellIds[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            funitureIds = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 funitureIds[i] = reader.ReadInt();
            }
            limit = reader.ReadUShort();
            orientations = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 orientations[i] = reader.ReadSByte();
            }
            

}


}


}