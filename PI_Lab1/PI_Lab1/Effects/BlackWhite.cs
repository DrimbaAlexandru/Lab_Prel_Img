using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Lab1.Effects
{
    class BlackWhite : IEffect
    {
        private double r_comp = 1, g_comp = 1, b_comp = 1;
        private int threshold = 127;
        public void apply( Bitmap image )
        {
            int i, j;
            for( i = 0; i < image.Height; i++ )
            {
                for( j = 0; j < image.Width; j++ )
                {
                    Color pixel = image.GetPixel( j, i );
                    int mean = ( int )( ( r_comp * pixel.R + g_comp * pixel.G + b_comp * pixel.B ) / ( r_comp + b_comp + g_comp ) );
                    mean = ( mean > threshold ) ? 255 : 0;
                    Color newColor = Color.FromArgb( mean, mean, mean );
                    image.SetPixel( j, i, newColor );
                }
            }
        }
    }
}
