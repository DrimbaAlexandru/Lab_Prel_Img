using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Lab1.Effects
{
    class DirectionalFilter : IEffect
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
            int i, j, k;
            int nr_dir = 4;
            double[] r = new double[ nr_dir ], g = new double[ nr_dir ], b = new double[ nr_dir ];
            int best_dir, dir;
            double diff;
            double best_diff;
            int h_start, h_end, v_start, v_end;
            Color c;
            Bitmap dest = new Bitmap( image.Width, image.Height );

            for( i = 0; i < image.Height; i++ )
            {
                v_start = Math.Max( -v_side, -i );
                v_end = Math.Min( v_side, image.Height - 1 - i );
                for( j = 0; j < image.Width; j++ )
                {
                    for( dir = 0; dir < nr_dir; dir++ )
                    {
                        r[ dir ] = g[ dir ] = b[ dir ] = 0;
                    }
                    h_start = Math.Max( -h_side, -j );
                    h_end = Math.Min( h_side, image.Width - 1 - j );
                    if( i == 448 && j == 182 )
                    {
                        j = j;
                    }
                    for( k = h_start; k <= h_end; k++ )
                    {
                        c = image.GetPixel( j + k, i );
                        r[ 0 ] += coeffs[ v_side ][ k + h_side ] * c.R;
                        g[ 0 ] += coeffs[ v_side ][ k + h_side ] * c.G;
                        b[ 0 ] += coeffs[ v_side ][ k + h_side ] * c.B;
                    }
                    for( k = v_start; k <= v_end; k++ )
                    {
                        c = image.GetPixel( j, i + k );
                        r[ 2 ] += coeffs[ k + v_side ][ h_side ] * c.R;
                        g[ 2 ] += coeffs[ k + v_side ][ h_side ] * c.G;
                        b[ 2 ] += coeffs[ k + v_side ][ h_side ] * c.B;
                    }
                    for( k = Math.Max( h_start, -v_end ); k <= Math.Min( h_end, -v_start ); k++ )
                    {
                        c = image.GetPixel( j + k, i - k );
                        r[ 1 ] += coeffs[ -k + v_side ][ k + h_side ] * c.R;
                        g[ 1 ] += coeffs[ -k + v_side ][ k + h_side ] * c.G;
                        b[ 1 ] += coeffs[ -k + v_side ][ k + h_side ] * c.B;
                    }
                    for( k = Math.Max( h_start, v_start ); k <= Math.Min( h_end, v_end ); k++ )
                    {
                        c = image.GetPixel( j + k, i + k );
                        r[ 3 ] += coeffs[ k + v_side ][ k + h_side ] * c.R;
                        g[ 3 ] += coeffs[ k + v_side ][ k + h_side ] * c.G;
                        b[ 3 ] += coeffs[ k + v_side ][ k + h_side ] * c.B;
                    }

                    c = image.GetPixel( j, i );
                    best_dir = 0;
                    best_diff = Int16.MaxValue;
                    for( dir = 0; dir < nr_dir; dir++ )
                    {
                        diff = Math.Abs( r[ dir ] - c.R ) + Math.Abs( g[ dir ] - c.G ) + Math.Abs( b[ dir ] - c.B );
                        if( diff < best_diff )
                        {
                            best_diff = diff;
                            best_dir = dir;
                        }
                    }

                    dest.SetPixel( j, i, fromRGB( r[ best_dir ], g[ best_dir ], b[ best_dir ] ) );
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

        public void set_coeffs( int v_side, int h_side )
        {
            this.v_side = v_side;
            this.h_side = h_side;
            this.coeffs = new double[ v_side * 2 + 1 ][];
            for( int i = 0; i < v_side * 2 + 1; i++ )
            {
                this.coeffs[ i ] = new double[ h_side * 2 + 1 ];
                for( int j = 0; j < h_side * 2 + 1; j++ )
                {
                    this.coeffs[ i ][ j ] = 1.0 / ( Math.Sqrt( ( v_side * 2 + 1 ) * ( h_side * 2 + 1 ) ) );
                }
            }
        }
    }
}