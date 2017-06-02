using Rebirth.Common.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rebirth.Common.GameData.Maps
{
    
    public class CellData
    {
        public CellData(CellData cell)
        {
            Floor = cell.Floor;
            LosMov = cell.LosMov;
            Los = cell.Los;
            FarmCell = cell.FarmCell;
            MapChangeData = cell.MapChangeData;
            MoveZone = cell.MoveZone;
            Speed = cell.Speed;
            Arrow = cell.Arrow;
            Mov = cell.Mov;
            NonWalkableDuringFight = cell.NonWalkableDuringFight;
            NonWalkableDuringRP = cell.NonWalkableDuringRP;
            TopArrow = cell.TopArrow;
            BottomArrow = cell.BottomArrow;
            RightArrow = cell.RightArrow;
            LeftArrow = cell.LeftArrow;
            Red = cell.Red;
            Blue = cell.Blue;
        }

        public CellData()
        { }

        // Methods
        internal void Init(BigEndianReader Reader, int MapVersion)
        {
            this.Floor = (Reader.ReadByte() * 10);
            if (this.Floor == -1280)
                return;

            if (MapVersion >= 9)
            {
                int tmpbytesv9 = Reader.ReadInt16();
                Mov = (tmpbytesv9 & 1) == 0;
                NonWalkableDuringFight = (tmpbytesv9 & 2) != 0;
                NonWalkableDuringRP = (tmpbytesv9 & 4) != 0;
                Los = (tmpbytesv9 & 8) == 0;
                Blue = (tmpbytesv9 & 16) != 0;
                Red = (tmpbytesv9 & 32) != 0;
                Visible = (tmpbytesv9 & 64) != 0;
                FarmCell = (tmpbytesv9 & 128) != 0;

                if (MapVersion >= 10)
                {
                    HavenbagCell = (tmpbytesv9 & 256) != 0;
                    TopArrow = (tmpbytesv9 & 512) != 0;
                    BottomArrow = (tmpbytesv9 & 1024) != 0;
                    RightArrow = (tmpbytesv9 & 2048) != 0;
                    LeftArrow = (tmpbytesv9 & 4096) != 0;
                }
                else
                {
                    TopArrow = (tmpbytesv9 & 256) != 0;
                    BottomArrow = (tmpbytesv9 & 512) != 0;
                    RightArrow = (tmpbytesv9 & 1024) != 0;
                    LeftArrow = (tmpbytesv9 & 2048) != 0;
                }
            }
            else
            {
                LosMov = Reader.ReadSByte();
              
                this.Los = (LosMov & 2) >> 1 == 1;
                this.Mov = (LosMov & 1) == 1;
                this.Visible = (LosMov & 64) >> 6 == 1;
                this.FarmCell = ((LosMov & 32) >> 5) == 1;
                this.Blue = (LosMov & 16) >> 4 == 1;
                this.Red = (LosMov & 8) >> 3 == 1;
                this.NonWalkableDuringRP = (LosMov & 128) >> 7 == 1;
                this.NonWalkableDuringFight = (LosMov & 4) >> 2 == 1;
            }
            this.Speed = Reader.ReadByte();
            this.MapChangeData = Reader.ReadByte();
            if (MapVersion > 5)
            {
                this.MoveZone = Reader.ReadByte();
            }
            if (MapVersion == 8)
            {
                int tmp = Reader.ReadByte();
                Arrow = 15 & tmp;
            }
        }

        public int Id;
        public bool Blue;
        public bool IsShoot;
        public bool FarmCell;
        public bool Los;
        public bool Mov
        {
            get;
            set;
        }
        public bool HavenbagCell;
        public bool NonWalkableDuringFight;
        public bool NonWalkableDuringRP;
        public bool Red;
        public bool Visible;
        public bool TopArrow;
        public bool BottomArrow;
        public bool RightArrow;
        public bool LeftArrow;
        public int Floor;
        public int LosMov;
        public uint MapChangeData;
        public int MoveZone;
        public int Speed;
        public int Arrow = 0;
    
        public bool IsRightChange
        {
            get
            {
                return (MapChangeData & 1) > 0 ? true : false;
            }
        }
        public bool IsLeftChange
        {
            get
            {
                return (MapChangeData & 16) > 0 ? true : false;
            }
        }
        public bool IsTopChange
        {
            get
            {
                return (MapChangeData & 64) > 0 ? true : false;
            }
        }
        public bool IsBotChange
        {
            get
            {
                return (MapChangeData & 4) > 0 ? true : false;
            }
        }
    }
}
