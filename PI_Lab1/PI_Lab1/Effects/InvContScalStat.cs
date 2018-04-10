using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Lab1.Effects
{
    class InvContScalStat : IEffect
    {
        private int v_side = 0;
        private int h_side = 0;
        private double coeff = 0;

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
            int i, j, k, l;
            double miu_r, miu_g, miu_b;
            double sigma_r, sigma_g, sigma_b;
            int h_start, h_end, v_start, v_end;
            Color c;
            Bitmap dest = new Bitmap( image.Width, image.Height );

            for( i = 0; i < image.Height; i++ )
            {
                v_start = Math.Max( -v_side, -i );
                v_end = Math.Min( v_side, image.Height - 1 - i );
                for( j = 0; j < image.Width; j++ )
                {
                    miu_r = miu_g = miu_b = 0;
                    sigma_r = sigma_b = sigma_g = 0;

                    h_start = Math.Max( -h_side, -j );
                    h_end = Math.Min( h_side, image.Width - 1 - j );
                    for( k = v_start; k <= v_end; k++ )
                    {
                        for( l = h_start; l <= h_end; l++ )
                        {
                            c = image.GetPixel( j + l, i + k );
                            miu_r += c.R;
                            miu_g += c.G;
                            miu_b += c.B;
                        }
                    }
                    miu_r *= coeff;
                    miu_g *= coeff;
                    miu_b *= coeff;

                    for( k = v_start; k <= v_end; k++ )
                    {
                        for( l = h_start; l <= h_end; l++ )
                        {
                            c = image.GetPixel( j + l, i + k );
                            sigma_r += Math.Pow( miu_r - c.R, 2 );
                            sigma_g += Math.Pow( miu_g - c.G, 2 );
                            sigma_b += Math.Pow( miu_b - c.B, 2 );
                        }
                    }
                    sigma_r *= coeff;
                    sigma_g *= coeff;
                    sigma_b *= coeff;

                    if( sigma_b <= 0 )
                        sigma_b = 0.000001;
                    if( sigma_g <= 0 )
                        sigma_g = 0.000001;
                    if( sigma_r <= 0 )
                        sigma_r = 0.000001;
                    dest.SetPixel( j, i, fromRGB( miu_r / Math.Sqrt( sigma_r ), miu_g / Math.Sqrt( sigma_g ), miu_b / Math.Sqrt( sigma_b ) ) );
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
            this.coeff = 1.0 / ( ( v_side * 2 + 1 ) * ( h_side * 2 + 1 ) );
        }
    }
}