using Rebirth.Common.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rebirth.Common.GameData.Maps
{
    
    public class Fixture
    {
        // Methods
        internal void Init(BigEndianReader Reader)
        {
            this.FixtureId = Reader.ReadInt();
            this.OffsetX = Reader.ReadShort();
            this.OffsetY = Reader.ReadShort();
            this.Rotation = Reader.ReadShort();
            this.xScale = Reader.ReadShort();
            this.yScale = Reader.ReadShort();
            this.RedMultiplier = Reader.ReadSByte();
            this.GreenMultiplier = Reader.ReadSByte();
            this.BlueMultiplier = Reader.ReadSByte();
            this.Hue = ((this.RedMultiplier | this.GreenMultiplier) | this.BlueMultiplier);
            this.Alpha = Reader.ReadByte();
        }

        public void Write(BigEndianWriter writer)
        {
            writer.WriteInt(FixtureId);
            writer.WriteShort((short)OffsetX);
            writer.WriteShort((short)OffsetY);
            writer.WriteShort((short)Rotation);
            writer.WriteShort((short)xScale);
            writer.WriteShort((short)yScale);
            writer.WriteSByte((sbyte)RedMultiplier);
            writer.WriteSByte((sbyte)GreenMultiplier);
            writer.WriteSByte((sbyte)BlueMultiplier);
            writer.WriteByte((byte)Alpha);
        }


        // Fields
        public int Alpha;
        public int BlueMultiplier;
        public int FixtureId;
        public int GreenMultiplier;
        public int Hue;
        public int OffsetX;
        public int OffsetY;
        public int RedMultiplier;
        public int Rotation;
        public int xScale;
        public int yScale;
    }
}
