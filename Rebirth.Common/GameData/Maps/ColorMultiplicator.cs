using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rebirth.Common.GameData.Maps
{
    
    public class ColorMultiplicator
    {
        // Methods
        public ColorMultiplicator(int red, int green, int blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
        }

        // Fields
        public double Blue;
        public double Green;
        public double Red;
    }
}
