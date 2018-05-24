using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Lab1.Effects
{
    class Inchidere:IEffect
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

        public void apply( System.Drawing.Bitmap image )
        {
            Erosion er = new Erosion();
            Dilation di = new Dilation();
            er.setParameters( B, B_offset_h, B_offset_v );
            di.setParameters( B, B_offset_h, B_offset_v );
            di.apply( image );
            er.apply( image );
        }

    }
}
