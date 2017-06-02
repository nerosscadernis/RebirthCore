﻿
using Rebirth.Common.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.Common.GameData.Elements.Test
{
    public class BlendedGraphicalElementData : NormalGraphicalElementData
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public BlendedGraphicalElementData(EleInstance instance, int id)
            : base(instance, id)
        {
        }

        public string BlendMode
        {
            get;
            set;
        }

        public override EleGraphicalElementTypes Type
        {
            get { return EleGraphicalElementTypes.BLENDED; }
        }

        public static new BlendedGraphicalElementData ReadFromStream(EleInstance instance, int id, BigEndianReader reader)
        {
            var data = new BlendedGraphicalElementData(instance, id);

            data.Gfx = reader.ReadInt();
            data.Height = reader.ReadByte();
            data.HorizontalSymmetry = reader.ReadBoolean();
            data.Origin = new Point(reader.ReadShort(), reader.ReadShort());
            data.Size = new Point(reader.ReadShort(), reader.ReadShort());

            data.BlendMode = reader.ReadUTF7BitLength();

            return data;
        }
    }
}
