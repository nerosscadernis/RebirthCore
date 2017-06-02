﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rebirth.Common.IO;

namespace Rebirth.Common.GameData.Maps.Elements
{
    
    public abstract class BasicElement
    {
        // Methods
        protected BasicElement()
        {
        }

        public static BasicElement GetElementFromType(int typeId)
        {
            switch (typeId)
            {
                case 2:
                    return new GraphicalElement();
                case 33:
                    return new SoundElement();
            }
            return null;
        }

        internal abstract void Init(BigEndianReader reader, int mapVersion);
        public abstract void Write(BigEndianWriter writer, int mapVersion);
    }
}
