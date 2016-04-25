using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTSP
{

    static class ColorSelector
    {

        private static int counter = 0;
        private static List<Color> colors = new List<Color>() { Color.AliceBlue, Color.DarkRed, Color.DarkSeaGreen };

        public static Color GetColor()
        {
            counter = (counter + 1) % colors.Count;
            return colors[counter];
        }



    }
}
