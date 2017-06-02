
using Rebirth.Common.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.Common.GameData.Elements.Test
{
    public class BoundingBoxGraphicalElementData : NormalGraphicalElementData
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public BoundingBoxGraphicalElementData(EleInstance instance, int id) : base(instance, id)
        {
        }

        public override EleGraphicalElementTypes Type
        {
            get
            {
                return EleGraphicalElementTypes.BOUNDING_BOX;
            }
        }

        public static new BoundingBoxGraphicalElementData ReadFromStream(EleInstance instance, int id, BigEndianReader reader)
        {
            var data = new BoundingBoxGraphicalElementData(instance, id);

            data.Gfx = reader.ReadInt();
            data.Height = reader.ReadByte();
            data.HorizontalSymmetry = reader.ReadBoolean();
            data.Origin = new Point(reader.ReadShort(), reader.ReadShort());
            data.Size = new Point(reader.ReadShort(), reader.ReadShort());

            return data;
        }
    }
}
