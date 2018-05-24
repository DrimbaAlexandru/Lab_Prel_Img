using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Lab1.Effects
{
    class Dilation : IEffect
    {
        int[ , ] B = null;
        int B_size = 0;
        int B_offset_h = 0, B_offset_v = 0;

        public void setParameters( int[ , ] B, int off_h, int off_v )
        {
            this.B = B;
            B_offset_h = off_h;
            B_offset_v = off_v;
            B_size = Math.Min( B.GetLength( 0 ), B.GetLength( 1 ) );
        }

        public void apply( Bitmap image )
        {
            if( B == null || B_size == 0 )
            {
                throw new ImageProcessingException( "B cannot be null and B's size cannot be 0" );
            }

            Bitmap dest = ( Bitmap )image.Clone();
            int vi_s = -B_offset_v, vi_e = B_size - B_offset_v;
            int vj_s = -B_offset_h, vj_e = B_size - B_offset_h;
            int maxR, maxG, maxB;
            Color p;

            for( int i = 0; i < image.Height; i++ )
            {
                for( int j = 0; j < image.Width; j++ )
                {
                    maxR = maxG = maxB = 0;

                    for( int vi = Math.Max( 0, i + vi_s ); vi < Math.Min( image.Height, i + vi_e ); vi++ )
                    {
                        for( int vj = Math.Max( 0, j + vj_s ); vj < Math.Min( image.Width, j + vj_e ); vj++ )
                        {
                            if( B[ vi - i + B_offset_v, vj - j + B_offset_h ] == 0 )
                            {
                                p = image.GetPixel( vj, vi );
                                maxR = Math.Max( p.R, maxR );
                                maxG = Math.Max( p.G, maxG );
                                maxB = Math.Max( p.B, maxB );
                            }
                        }
                    }
                    dest.SetPixel( j, i, Color.FromArgb( maxR, maxG, maxB ) );
                }
            }
            for( int i = 0; i < image.Height; i++ )
            {
                for( int j = 0; j < image.Width; j++ )
                {
                    image.SetPixel( j, i, dest.GetPixel( j, i ) );
                }
            }
        }
    }
}