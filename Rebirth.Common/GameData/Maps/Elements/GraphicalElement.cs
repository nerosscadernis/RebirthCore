using Rebirth.Common.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rebirth.Common.GameData.Maps.Elements
{
    
    public class GraphicalElement : BasicElement
    {
        // Methods
        internal override void Init(BigEndianReader Reader, int MapVersion)
        {
            this.ElementId = Convert.ToInt32(Reader.ReadUInt());
            this.Hue = new ColorMultiplicator(Reader.ReadSByte(), Reader.ReadSByte(), Reader.ReadSByte());
            this.Shadow = new ColorMultiplicator(Reader.ReadSByte(), Reader.ReadSByte(), Reader.ReadSByte());
            if ((MapVersion <= 4))
            {
                this.OffsetX = Reader.ReadSByte();
                this.OffsetY = Reader.ReadSByte();
                this.PixelOffsetX = (this.OffsetX * 43);
                this.PixelOffsetY = (this.OffsetY * 21.5);
            }
            else
            {
                this.PixelOffsetX = Reader.ReadShort();
                this.PixelOffsetY = Reader.ReadShort();
                this.OffsetX = (this.PixelOffsetX / 43);
                this.OffsetY = (this.PixelOffsetY / 21.5);
            }
            this.Altitude = Reader.ReadSByte();
            this.Identifier = (int)Reader.ReadUInt();
        }

        public override void Write(BigEndianWriter writer, int mapVersion)
        {
            writer.WriteByte(2);
            writer.WriteUInt((uint)ElementId);
            writer.WriteSByte((sbyte)Hue.Red);
            writer.WriteSByte((sbyte)Hue.Green);
            writer.WriteSByte((sbyte)Hue.Blue);
            writer.WriteSByte((sbyte)Shadow.Red);
            writer.WriteSByte((sbyte)Shadow.Green);
            writer.WriteSByte((sbyte)Shadow.Blue);
            if (mapVersion <= 4)
            {
                writer.WriteSByte((sbyte)OffsetX);
                writer.WriteSByte((sbyte)OffsetY);
            }
            else
            {
                writer.WriteShort((short)PixelOffsetX);
                writer.WriteShort((short)PixelOffsetY);
            }
            writer.WriteSByte((sbyte)Altitude);
            writer.WriteUInt((uint)Identifier);
        }

        // Fields
        public int Altitude;
        public int ElementId;
        public ColorMultiplicator FinalTeint;
        public ColorMultiplicator Hue;
        public int Identifier;
        public double OffsetX;
        public double OffsetY;
        public double PixelOffsetX;
        public double PixelOffsetY;
        public ColorMultiplicator Shadow;
    }
}
