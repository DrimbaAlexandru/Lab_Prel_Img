using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Lab1.Effects
{
    class Pseudocolor : IEffect
    {
        private double r_comp = 1, g_comp = 1, b_comp = 1;

        private byte[ , ] map = { { 0, 0, 0 }, { 0, 0, 1 }, { 0, 0, 2 }, { 0, 0, 3 }, { 0, 0, 4 }, { 0, 0, 5 }, { 15, 2, 0 }, { 17, 3, 0 }, { 19, 3, 0 }, { 21, 5, 0 }, { 23, 6, 0 }, { 25, 7, 0 }, { 27, 8, 1 }, { 29, 9, 1 }, { 26, 0, 0 }, { 29, 5, 5 }, { 32, 5, 5 }, { 35, 5, 5 }, { 38, 5, 5 }, { 41, 5, 5 }, { 44, 5, 5 }, { 47, 5, 5 }, { 50, 5, 5 }, { 53, 5, 5 }, { 56, 5, 5 }, { 59, 5, 5 }, { 48, 24, 9 }, { 53, 26, 11 }, { 55, 27, 12 }, { 57, 28, 13 }, { 59, 29, 14 }, { 61, 30, 15 }, { 63, 31, 16 }, { 63, 31, 0 }, { 63, 33, 0 }, { 63, 35, 0 }, { 63, 37, 0 }, { 63, 39, 0 }, { 63, 41, 0 }, { 63, 40, 0 }, { 63, 45, 0 }, { 63, 47, 0 }, { 63, 49, 0 }, { 63, 51, 0 }, { 63, 53, 0 }, { 63, 63, 0 }, { 63, 63, 2 }, { 63, 63, 4 }, { 63, 63, 6 }, { 63, 63, 8 }, { 63, 63, 10 }, { 63, 63, 12 }, { 63, 63, 14 }, { 63, 63, 16 }, { 63, 63, 18 }, { 63, 63, 20 }, { 63, 63, 22 }, { 63, 63, 24 }, { 63, 63, 26 }, { 63, 63, 28 }, { 63, 63, 30 }, { 61, 61, 61 }, { 62, 62, 62 }, { 63, 63, 63 } };

        public void apply( Bitmap image )
        {
            int i, j;
            for( i = 0; i < image.Height; i++ )
            {
                for( j = 0; j < image.Width; j++ )
                {
                    Color pixel = image.GetPixel( j, i );
                    int mean = ( int )( ( r_comp * pixel.R + g_comp * pixel.G + b_comp * pixel.B ) / ( r_comp + b_comp + g_comp ) );
                    mean = ( mean > 255 ) ? 255 : mean;
                    mean = ( mean < 0 ) ? 0 : mean;
                    Color newColor = Color.FromArgb( map[ mean >> 2, 0 ] << 2, map[ mean >> 2, 1 ] << 2, map[ mean >> 2, 2 ] << 2 );
                    image.SetPixel( j, i, newColor );
                }
            }
        }
    }
}
