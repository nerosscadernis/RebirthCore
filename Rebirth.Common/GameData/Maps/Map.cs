using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rebirth.Common.IO;
using System.IO;

namespace Rebirth.Common.GameData.Maps
{
    // TODO : Implement IMapData
    public class Map
    {

        public List<Fixture> BackgroundFixtures = new List<Fixture>();
        public int BackgroundAlpha;
        public int BackgroundRed;
        public int BackgroundGreen;
        public int BackgroundBlue;
        public int BackgroundsCount;
        public int BottomNeighbourId;
        public List<CellData> Cells = new List<CellData>();
        public bool Encrypted;
        public int EncryptedVersion;
        public List<Fixture> ForegroundFixtures = new List<Fixture>();
        public int ForegroundsCount;
        public int GroundCRC;
        public int Id;
        public bool IsUsingNewMovementSystem;
        public List<Layer> Layers = new List<Layer>();
        public int LayersCount;
        public int LeftNeighbourId;
        public int MapType;
        public int MapVersion;
        public int PresetId;
        public int RelativeId;
        public int RightNeighbourId;
        public int ShadowBonusOnEntities;
        public int SubAreaId;
        public int TopNeighbourId;
        public bool UseLowPassFilter;
        public bool UseReverb;
        public int ZoomOffsetX;
        public int ZoomOffsetY;
        public double ZoomScale;

        public void Init(BigEndianReader reader)
        {
            reader.ReadByte();
            MapVersion = reader.ReadByte();
            Id = (int)reader.ReadUInt();

            if (MapVersion >= 7)
            {
                Encrypted = reader.ReadBoolean();
                EncryptedVersion = reader.ReadByte();
                int count = reader.ReadInt();
                if (Encrypted)
                {
                    //byte[] buffer = CustomHex.ToArray(CustomHex.FromString("649ae451ca33ec53bbcbcc33becf15f4", false));
                    byte[] buffer = Encoding.ASCII.GetBytes("649ae451ca33ec53bbcbcc33becf15f4");
                    byte[] buffer2 = reader.ReadBytes(count);
                    int num7 = (buffer2.Length - 1);
                    int n = 0;
                    while (n <= num7)
                    {
                        buffer2[n] = (byte)(buffer2[n] ^ buffer[n % buffer.Length]);
                        n += 1;
                    }
                    reader = new BigEndianReader(buffer2);
                }
            }

            RelativeId = (int)reader.ReadUInt();
            MapType = reader.ReadByte();
            SubAreaId = reader.ReadInt();
            TopNeighbourId = reader.ReadInt();
            BottomNeighbourId = reader.ReadInt();
            LeftNeighbourId = reader.ReadInt();
            RightNeighbourId = reader.ReadInt();
            ShadowBonusOnEntities = (int)reader.ReadUInt();

            if (MapVersion >= 9)
            {
                int readColor = reader.ReadInt();
                readColor = (int)reader.ReadUInt();

            }
            else if (MapVersion >= 3)
            {
                BackgroundRed = reader.ReadByte();
                BackgroundGreen = reader.ReadByte();
                BackgroundBlue = reader.ReadByte();
            }

            if (MapVersion >= 4)
            {
                ZoomScale = (Convert.ToDouble(reader.ReadUShort()) / 100);
                ZoomOffsetX = reader.ReadShort();
                ZoomOffsetY = reader.ReadShort();

                if (ZoomScale < 1)
                {
                    ZoomScale = 1;
                    ZoomOffsetY = 0;
                    ZoomOffsetX = 0;
                }
            }

            UseLowPassFilter = reader.ReadByte() == 1;
            UseReverb = reader.ReadByte() == 1;

            if (UseReverb)
            {
                PresetId = reader.ReadInt();
            }
            else
            {
                PresetId = -1;
            }

            // Fixtures

            BackgroundsCount = reader.ReadByte();
            for (int i = 1; i <= BackgroundsCount; i++)
            {
                Fixture item = new Fixture();
                item.Init(reader);
                BackgroundFixtures.Add(item);
            }

            ForegroundsCount = reader.ReadByte();
            for (int j = 1; j <= ForegroundsCount; j++)
            {
                Fixture fixture2 = new Fixture();
                fixture2.Init(reader);
                ForegroundFixtures.Add(fixture2);
            }

            reader.ReadInt();
            GroundCRC = reader.ReadInt();
            LayersCount = reader.ReadByte();

            // Layers

            for (int k = 1; k <= LayersCount; k++)
            {
                Layer layer = new Layer();
                layer.Init(reader, MapVersion);
                Layers.Add(layer);
            }

            // Cells

            uint oldMvtSys = 0;
            for (int m = 0; m < 560; m++)
            {
                CellData data = new CellData();
                if (Id == 84677637 && m == 255)
                {
                    data.Init(reader, MapVersion);
                }
                else
                    data.Init(reader, MapVersion);
                if (oldMvtSys == 0)
                {
                    oldMvtSys = (uint)data.MoveZone;
                }
                if (data.MoveZone != oldMvtSys)
                {
                    IsUsingNewMovementSystem = true;
                }
                Cells.Add(data);
            }
        }
    }
}
