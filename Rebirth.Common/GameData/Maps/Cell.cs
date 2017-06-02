using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rebirth.Common.IO;
using Rebirth.Common.GameData.Maps.Elements;

namespace Rebirth.Common.GameData.Maps
{
    
    public class Cell
    {
        // Methods
        internal void Init(BigEndianReader Reader, int MapVersion)
        {
            this.CellId = Reader.ReadShort();
            this.ElementsCount = Reader.ReadShort();
            int elementsCount = this.ElementsCount;
            for (int i = 0; i < elementsCount; i++)
            {
                BasicElement elementFromType = BasicElement.GetElementFromType(Reader.ReadByte());
                elementFromType.Init(Reader, MapVersion);
                this.Elements.Add(elementFromType);
            }
        }

        public void Write(BigEndianWriter writer, int mapVersion)
        {
            writer.WriteShort((short)CellId);
            writer.WriteShort((short)ElementsCount);
            foreach (var item in Elements)
            {
                item.Write(writer, mapVersion);
            }
        }

        // Fields
        public int CellId;
        public List<BasicElement> Elements = new List<BasicElement>();
        public int ElementsCount;
    }
}
