using Rebirth.Common.IO;
using Rebirth.Common.Protocol.Enums;
using Rebirth.World.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.World.Datas.Characters
{
    public class CharacterInfos
    {
        #region Properties
        public double Id { get; set; }
        public int AccountId { get; set; }
        public string Nickname { get; set; }
        public string Name { get; set; }
        public double Experience { get; set; }
        public int MapId { get; set; }
        public short CellId { get; set; }
        public DirectionsEnum Direction { get; set; }
        public byte Sex { get; set; }
        public int Breed { get; set; }
        public int DeathCount { get; set; }
        public int LastLevel { get; set; }
        public List<short> Zaaps { get; set; }
        public List<short> Titles { get; set; }
        public List<short> Ornaments { get; set; }
        public List<short> Finishers { get; set; }
        public uint ZaapSave { get; set; }
        public short ActiveTitle { get; set; }
        public short ActiveOrnament { get; set; }
        public short ActiveFinisher { get; set; }
        public uint SpellsPoint { get; set; }
        public uint StatsPoint { get; set; }
        public long LastConnexion { get; set; }

        public byte Level { get { return ExperienceManager.Instance.GetCharacterLevel((long)Experience); } }
        #endregion

        #region Contructors
        public CharacterInfos()
        {
        }
        public CharacterInfos(double id, byte[] datas)
        {
            Id = id;

            var reader = new BigEndianReader(datas);
            int count = 0;
            Zaaps = new List<short>();
            Titles = new List<short>();
            Ornaments = new List<short>();
            Finishers = new List<short>();

            AccountId = reader.ReadInt();
            Nickname = reader.ReadUTF();
            Name = reader.ReadUTF();
            Experience = reader.ReadDouble();
            MapId = reader.ReadInt();
            CellId = reader.ReadShort();
            Direction = (DirectionsEnum)reader.ReadByte();
            Sex = reader.ReadByte();
            Breed = reader.ReadInt();
            DeathCount = reader.ReadInt();
            LastLevel = reader.ReadInt();
            count = reader.ReadInt();
            for (int i = 0; i < count; i++) {
                Zaaps.Add(reader.ReadShort());
            }
            count = reader.ReadInt();
            for (int i = 0; i < count; i++) {
                Titles.Add(reader.ReadShort());
            }
            count = reader.ReadInt();
            for (int i = 0; i < count; i++) {
                Ornaments.Add(reader.ReadShort());
            }
            count = reader.ReadInt();
            for (int i = 0; i < count; i++) {
                Finishers.Add(reader.ReadShort());
            }
            ZaapSave = reader.ReadUInt();
            ActiveTitle = reader.ReadShort();
            ActiveOrnament = reader.ReadShort();
            ActiveFinisher = reader.ReadShort();
            LastConnexion = reader.ReadLong();
        }
        #endregion

        #region Methods
        public byte[] GetDatas()
        {
            var writer = new BigEndianWriter();
            writer.WriteInt(AccountId);
            writer.WriteUTF(Nickname);
            writer.WriteUTF(Name);
            writer.WriteDouble(Experience);
            writer.WriteInt(MapId);
            writer.WriteShort(CellId);
            writer.WriteByte((byte)Direction);
            writer.WriteByte(Sex);
            writer.WriteInt(Breed);
            writer.WriteInt(DeathCount);
            writer.WriteInt(LastLevel);
            writer.WriteInt(Zaaps.Count);
            foreach (var zaap in Zaaps)
            {
                writer.WriteShort(zaap);
            }
            writer.WriteInt(Titles.Count);
            foreach (var title in Titles)
            {
                writer.WriteShort(title);
            }
            writer.WriteInt(Ornaments.Count);
            foreach (var ornament in Ornaments)
            {
                writer.WriteShort(ornament);
            }
            writer.WriteInt(Finishers.Count);
            foreach (var finish in Finishers)
            {
                writer.WriteShort(finish);
            }
            writer.WriteUInt(ZaapSave);
            writer.WriteShort(ActiveTitle);
            writer.WriteShort(ActiveOrnament);
            writer.WriteShort(ActiveFinisher);
            writer.WriteLong(LastConnexion);
            return writer.Data;
        }
        #endregion
    }
}
