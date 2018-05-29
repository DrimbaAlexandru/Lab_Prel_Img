using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Lab1.Effects
{
    class MorphologicGradient : IEffect
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
            Bitmap dilated = ( Bitmap )image.Clone();
            Bitmap eroded = ( Bitmap )image.Clone();

            Dilation dilation = new Dilation();
            Erosion erosion = new Erosion();

            int i, j;

            Color p1, p2;

            erosion.setParameters( B, B_offset_h, B_offset_v );
            dilation.setParameters( B, B_offset_h, B_offset_v );
            erosion.apply( eroded );
            dilation.apply( dilated );

            for( i = 0; i < image.Height; i++ )
            {
                for( j = 0; j < image.Width; j++ )
                {
                    p1 = dilated.GetPixel( j, i );
                    p2 = eroded.GetPixel( j, i );
                    image.SetPixel( j, i, Color.FromArgb( p1.R - p2.R, p1.G - p2.G, p1.B - p2.B ) );
                }
            }
        }
    }
}