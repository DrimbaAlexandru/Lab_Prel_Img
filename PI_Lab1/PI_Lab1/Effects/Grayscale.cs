using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Lab1.Effects
{
    class Grayscale : IEffect
    {
        private double r_comp = 1, g_comp = 1, b_comp = 1;

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
                    Color newColor = Color.FromArgb( mean, mean, mean );
                    image.SetPixel( j, i, newColor );
                }
            }
        }

        public void setRGBcoeffs( double r, double g, double b) 
        {
            if( r + g + b <= 0 || r < 0 || g < 0 || b < 0 )
                throw new ImageProcessingException( "Invalid parameters" );

            r_comp = r;
            g_comp = g;
            b_comp = b;
        }
    }
}
