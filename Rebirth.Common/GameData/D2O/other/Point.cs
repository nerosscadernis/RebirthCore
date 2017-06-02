﻿using Rebirth.Common.GameData.D2O;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.Common.GameData.D2O
{
    public class Point : IDataObject
    {
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int x;
        public int y;
        public double length;
    }
}
