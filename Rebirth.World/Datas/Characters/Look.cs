using Rebirth.Common.Extensions;
using Rebirth.Common.IO;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rebirth.World.Datas.Characters
{
    public class Look
    {
        #region Vars
        private Dictionary<int, int> _colors = new Dictionary<int, int>();
        private List<short> _scales = new List<short>();
        private List<short> _skins = new List<short>();
        private List<SubLook> _subLooks = new List<SubLook>();
        private short _bonesID;
        private SubEntityBindingPointCategoryEnum _binding;
        #endregion

        #region Properties
        public List<SubLook> SubLooks
        {
            get
            {
                return this._subLooks;
            }
        }
        public short BonesID
        {
            get
            {
                return this._bonesID;
            }
            set
            {
                this._bonesID = value;
            }
        }
        public List<short> Skins
        {
            get
            {
                return this._skins;
            }
        }
        public List<short> Scales
        {
            get
            {
                return this._scales;
            }
        }
        public Dictionary<int, int> Colors
        {
            get
            {
                return this._colors;
            }
        }
        public SubEntityBindingPointCategoryEnum Binging
        {
            get
            {
                return _binding;
            }
        }
        #endregion

        #region Constructors / Parsers
        public Look()
        {}
        public Look(byte[] datas)
        {
            _colors = new Dictionary<int, int>();
            _scales = new List<short>();
            _skins = new List<short>();
            _subLooks = new List<SubLook>();

            var reader = new BigEndianReader(datas);
            int count = 0;

            count = reader.ReadShort();
            for (int i = 0; i < count; i++)
            {
                _colors.Add(reader.ReadInt(), reader.ReadInt());
            }
            count = reader.ReadShort();
            for (int i = 0; i < count; i++)
            {
                _scales.Add(reader.ReadShort());
            }
            count = reader.ReadShort();
            for (int i = 0; i < count; i++)
            {
                _skins.Add(reader.ReadShort());
            }
            count = reader.ReadShort();
            for (int i = 0; i < count; i++)
            {
                
            }
            _bonesID = reader.ReadShort();
            _binding = (SubEntityBindingPointCategoryEnum)reader.ReadByte();
        }
        public Look(short bones, short[] skins, Dictionary<int, int> indexedColors, short[] scales, SubLook[] subLooks)
        {
            this._bonesID = bones;
            this._skins = skins.ToList<short>();
            this._colors = indexedColors;
            this._scales = scales.ToList<short>();
            this._subLooks = subLooks.ToList<SubLook>();
        }

        public static Look Parse(string str)
        {
            if (string.IsNullOrEmpty(str) || str[0] != '{')
            {
                Console.WriteLine("Incorrect EntityLook format : {0}", str);
                return new Look();
            }
            int i = 1;
            int num = str.IndexOf('|');
            if (num == -1)
            {
                num = str.IndexOf("}");
                if (num == -1)
                {
                    throw new System.Exception("Incorrect EntityLook format : " + str);
                }
            }
            short bones = short.Parse(str.Substring(i, num - i));
            i = num + 1;
            short[] skins = new short[0];
            if ((num = str.IndexOf('|', i)) != -1 || (num = str.IndexOf('}', i)) != -1)
            {
                skins = Look.ParseCollection<short>(str.Substring(i, num - i), new Func<string, short>(short.Parse));
                i = num + 1;
            }
            Tuple<int, int>[] source = new Tuple<int, int>[0];
            if ((num = str.IndexOf('|', i)) != -1 || (num = str.IndexOf('}', i)) != -1)
            {
                source = Look.ParseCollection<Tuple<int, int>>(str.Substring(i, num - i), new Func<string, Tuple<int, int>>(Look.ParseIndexedColor));
                i = num + 1;
            }
            short[] scales = new short[0];
            if ((num = str.IndexOf('|', i)) != -1 || (num = str.IndexOf('}', i)) != -1)
            {
                scales = Look.ParseCollection<short>(str.Substring(i, num - i), new Func<string, short>(short.Parse));
                i = num + 1;
            }
            List<SubLook> list = new List<SubLook>();
            while (i < str.Length)
            {
                int num2 = str.IndexOf('@', i, 3);
                int num3 = str.IndexOf('=', num2 + 1, 3);
                byte category = byte.Parse(str.Substring(i, num2 - i));
                byte b = byte.Parse(str.Substring(num2 + 1, num3 - (num2 + 1)));
                int num4 = 0;
                int num5 = num3 + 1;
                System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
                do
                {
                    stringBuilder.Append(str[num5]);
                    if (str[num5] == '{')
                    {
                        num4++;
                    }
                    else
                    {
                        if (str[num5] == '}')
                        {
                            num4--;
                        }
                    }
                    num5++;
                }
                while (num4 > 0);
                list.Add(new SubLook((sbyte)b, (SubEntityBindingPointCategoryEnum)category, Look.Parse(stringBuilder.ToString())));
                i = num5 + 1;
            }
            return new Look(bones, skins, source.ToDictionary((Tuple<int, int> x) => x.Item1, (Tuple<int, int> x) => x.Item2), scales, list.ToArray());
        }
        private static Tuple<int, int> ParseIndexedColor(string str)
        {
            int num = str.IndexOf("=");
            bool flag = str[num + 1] == '#';
            int item = int.Parse(str.Substring(0, num));
            int item2 = int.Parse(str.Substring(num + (flag ? 2 : 1), str.Length - (num + (flag ? 2 : 1))), flag ? System.Globalization.NumberStyles.HexNumber : System.Globalization.NumberStyles.Integer);
            return Tuple.Create<int, int>(item, item2);
        }
        private static T[] ParseCollection<T>(string str, Func<string, T> converter)
        {
            T[] result;
            if (string.IsNullOrEmpty(str))
            {
                result = new T[0];
            }
            else
            {
                int num = 0;
                int num2 = str.IndexOf(',', 0);
                if (num2 == -1)
                {
                    result = new T[]
                    {
                        converter(str)
                    };
                }
                else
                {
                    T[] array = new T[str.CountOccurences(',', num, str.Length - num) + 1];
                    int num3 = 0;
                    while (num2 != -1)
                    {
                        array[num3] = converter(str.Substring(num, num2 - num));
                        num = num2 + 1;
                        num2 = str.IndexOf(',', num);
                        num3++;
                    }
                    array[num3] = converter(str.Substring(num, str.Length - num));
                    result = array;
                }
            }
            return result;
        }
        public EntityLook GetEntityLook()
        {

            List<uint> currentSkins = new List<uint>();
            foreach (var skin in Skins)
            {
                currentSkins.Add((uint)skin);
            }

            List<int> currentScales = new List<int>();
            foreach (var scale in Scales)
            {
                currentScales.Add((int)scale);
            }

            EntityLook entity = new EntityLook()
            {
                bonesId = (uint)BonesID,
                scales = currentScales.ToArray(),
                skins = currentSkins.ToArray(),
                subentities = SubLooks.Select(e => e.GetSubEntity()).ToArray(),
                indexedColors = Colors.Select(entry => entry.Value + (16777216 * entry.Key)).ToArray(),
            };
            return entity;
        }
        #endregion

        #region Methods
        public void UpdateColor(int index, int color)
        {
            _colors[index] = color;
        }
        public void RemoveColor(int index)
        {
            _colors.Remove(index);
        }
        public void AddSkin(short skin)
        {
            if (!_skins.Contains(skin))
                _skins.Add(skin);
        }
        public void RemoveSkin(short skin)
        {
            _skins.Remove(skin);
        }

        public byte[] GetDatas()
        {
            var writer = new BigEndianWriter();
            int count = 0;

            writer.WriteShort((short)_colors.Count);
            foreach (var item in _colors)
            {
                writer.WriteInt(item.Key);
                writer.WriteInt(item.Value);
            }
            writer.WriteShort((short)_scales.Count);
            foreach (var item in _scales)
            {
                writer.WriteShort(item);
            }
            writer.WriteShort((short)_skins.Count);
            foreach (var item in _skins)
            {
                writer.WriteShort(item);
            }
            writer.WriteShort((short)_subLooks.Count);
            for (int i = 0; i < count; i++)
            {

            }
            writer.WriteShort(_bonesID);
            writer.WriteByte((byte)_binding);

            return writer.Data;
        }
        #endregion
    }
}
