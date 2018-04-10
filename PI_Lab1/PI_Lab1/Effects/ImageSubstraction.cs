using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Lab1.Effects
{
    class ImageSubstraction : IEffect
    {
        private Bitmap operand_b = null;
        private int threshold = 0;

        public void set_operand_b( Bitmap image )
        {
            operand_b = image;
        }

        public void set_threshold( int th )
        {
            threshold = th;
        }

        public void apply( Bitmap image )
        {
            int i, j;
            Color pixel_1, pixel_2;
            int r;
            int g;
            int b;

            if( operand_b == null )
            {
                throw new ImageProcessingException( "Operand B must not be null" );
            }
            if( operand_b.Height != image.Height || operand_b.Width != image.Width )
            {
                throw new ImageProcessingException( "The two operands must have the same size" );
            }

            for( i = 0; i < image.Height; i++ )
            {
                for( j = 0; j < image.Width; j++ )
                {
                    pixel_1 = image.GetPixel( j, i );
                    pixel_2 = operand_b.GetPixel( j, i );

                    r = 255;
                    g = 255;
                    b = 255;

                    if( Math.Abs( ( int )pixel_1.R - pixel_2.R ) >= threshold ||
                        Math.Abs( ( int )pixel_1.G - pixel_2.G ) >= threshold ||
                        Math.Abs( ( int )pixel_1.B - pixel_2.B ) >= threshold )
                    {
                        r = pixel_1.R;
                        g = pixel_1.G;
                        b = pixel_1.B;
                    }

                    image.SetPixel( j, i, Color.FromArgb( r, g, b ) );
                    //image.SetPixel( j, i, Color.FromArgb( limitColor( mean + r_diff ), limitColor( mean + g_diff ), limitColor( mean + b_diff ) ) );
                }
            }
        }
    }
}
