using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Lab1.Effects
{
    class Filter : IEffect
    {
        private double[][] coeffs = null;
        private int v_side = 0;
        private int h_side = 0;

        private Color fromRGB( double r, double g, double b )
        {
            if( r < 0 )
                r = 0;
            if( g < 0 )
                g = 0;
            if( b < 0 )
                b = 0;
            if( r > 255 )
                r = 255;
            if( g > 255 )
                g = 255;
            if( b > 255 )
                b = 255;
            return Color.FromArgb( ( int )r, ( int )g, ( int )b );
        }

        public void apply( Bitmap image )
        {
            if( coeffs == null )
            {
                throw new ImageProcessingException( "Filter coeffs not set" );
            }
            int i, j, k, l;
            double r, g, b;
            int h_start, h_end, v_start, v_end;
            Color c;
            Bitmap dest = new Bitmap( image.Width, image.Height );

            for( i = 0; i < image.Height; i++ )
            {
                v_start = Math.Max( -v_side, -i );
                v_end = Math.Min( v_side, image.Height - 1 - i );
                for( j = 0; j < image.Width; j++ )
                {
                    r = g = b = 0;
                    h_start = Math.Max( -h_side, -j );
                    h_end = Math.Min( h_side, image.Width - 1 - j );
                    for( k = v_start; k <= v_end; k++ )
                    {
                        for( l = h_start; l <= h_end; l++ )
                        {
                            c = image.GetPixel( j + l, i + k );
                            r += coeffs[ k + v_side ][ l + h_side ] * c.R;
                            g += coeffs[ k + v_side ][ l + h_side ] * c.G;
                            b += coeffs[ k + v_side ][ l + h_side ] * c.B;
                        }
                    }
                    dest.SetPixel( j, i, fromRGB( r, g, b ) );
                }
            }
            for( i = 0; i < image.Height; i++ )
            {
                for( j = 0; j < image.Width; j++ )
                {
                    image.SetPixel( j, i, dest.GetPixel( j, i ) );
                }
            }
        }

        public void set_coeffs( int v_side, int h_side, double[][] coeffs )
        {
            if( coeffs.Length < v_side * 2 + 1 )
            {
                throw new ImageProcessingException( "Less vertical coeffs than filter height" );
            }
            if( coeffs[ 0 ].Length < h_side * 2 + 1 )
            {
                throw new ImageProcessingException( "Less horizontal coeffs than filter height" );
            }
            this.v_side = v_side;
            this.h_side = h_side;
            this.coeffs = coeffs;
        }
    }
}
