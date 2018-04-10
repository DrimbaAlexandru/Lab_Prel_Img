using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Lab1.Effects
{
    class ContrastCompression : IEffect
    {
        private int limitColor( int value )
        {
            value = ( value > 255 ) ? 255 : value;
            value = ( value < 0 ) ? 0 : value;
            return value;
        }

        public void apply( Bitmap image )
        {
            int i, j;
            Color pixel;
            int mean;
            int r;
            int g;
            int b;

            for( i = 0; i < image.Height; i++ )
            {
                for( j = 0; j < image.Width; j++ )
                {
                    pixel = image.GetPixel( j, i );

                    mean = ( int )( ( pixel.R + pixel.G + pixel.B ) / ( 3 ) );
                    //miu_r = pixel.R - mean;
                    //miu_g = pixel.G - mean;
                    //miu_b = pixel.B - mean;

                    //mean = ( mean > 255 ) ? 255 : mean;
                    //mean = ( mean < 0 ) ? 0 : mean;
                    mean = ( int )( 255.0 / Math.Log( 256.0 ) * Math.Log( 1 + mean ) );

                    //miu_r = limitColor( mean + miu_r );
                    //miu_g = limitColor( mean + miu_g );
                   // miu_b = limitColor( mean + miu_b );
                    image.SetPixel( j, i, Color.FromArgb( mean, mean, mean ) );
                    //image.SetPixel( j, i, Color.FromArgb( limitColor( mean + r_diff ), limitColor( mean + g_diff ), limitColor( mean + b_diff ) ) );
                }
            }
        }
    }
}
