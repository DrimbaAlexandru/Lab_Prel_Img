using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Lab1.Effects
{
    class Pixelate : IEffect
    {
        Int32 pixelateSize;

        public void setParameters( Int32 pixelateSize )
        {
            this.pixelateSize = pixelateSize;
        }

        public void apply( Bitmap image )
        {
            int i, j, vi, vj;
            Bitmap pixelated = ( Bitmap )image.Clone();
            Int32 r, g, b;
            int cnt_x, cnt_y;
            Color p;

            for( i = 0; i < image.Height; i += pixelateSize )
            {
                for( j = 0; j < image.Width; j += pixelateSize )
                {
                    r = g = b = 0;
                    cnt_x = Math.Min( pixelateSize, image.Width - j );
                    cnt_y = Math.Min( pixelateSize, image.Height - i );
                    for( vi = i; vi < cnt_y + i; vi++ )
                    {
                        for( vj = j; vj < j + cnt_x; vj++ )
                        {
                            p = image.GetPixel( vj, vi );
                            r += p.R;
                            g += p.G;
                            b += p.B;
                        }
                    }
                    r /= cnt_x * cnt_y;
                    g /= cnt_x * cnt_y;
                    b /= cnt_x * cnt_y;
                    p = Color.FromArgb( r, g, b );
                    for( vi = i; vi < cnt_y + i; vi++ )
                    {
                        for( vj = j; vj < j + cnt_x; vj++ )
                        {
                            pixelated.SetPixel( vj, vi, p );
                        }
                    }
                }
            }

            for( i = 0; i < image.Height; i++ )
            {
                for( j = 0; j < image.Width; j++ )
                {
                    image.SetPixel( j, i, pixelated.GetPixel( j, i ) );
                }
            }
        }
    }
}