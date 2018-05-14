using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Lab1.Effects
{
    class ScatteredTiles : IEffect
    {
        private int tileSize = 0;
        private int scatterAmount = 0;

        public void apply(Bitmap image)
        {
            Bitmap copy = (Bitmap)image.Clone();

            for (int i =0; i < tileSize; i++)
            {
                for (int j = 0; j < tileSize; j++)
                {

                }
            }
        }

        public void setParameters(int tiles, int amount)
        {
            tileSize = tiles;
            scatterAmount = amount;
        }
    }
}
