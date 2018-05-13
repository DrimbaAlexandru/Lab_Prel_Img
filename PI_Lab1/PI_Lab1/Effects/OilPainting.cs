using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Lab1.Effects
{
    class OilPainting : IEffect
    {
        private int brush_width = 1;
        private int nr_colors = 255;

        public void setParameters( int brush_width, int nr_colors )
        {
            this.brush_width = brush_width;
            this.nr_colors = nr_colors;
        }

        public void apply( Bitmap image )
        {
            int[] intensity_count = new int[ nr_colors ];
            int[] average_R = new int[ nr_colors ];
            int[] average_G = new int[ nr_colors ];
            int[] average_B = new int[ nr_colors ];
            int i, j, vi, vj;
            Color pixel;
            int bin;
            Bitmap dest = ( Bitmap )image.Clone();

            for( i = 0; i < image.Height; i++ )
            {
                for( j = 0; j < image.Width; j++ )
                {
                    for( int k = 0; k < nr_colors; k++ )
                    {
                        intensity_count[ k ] = average_B[ k ] = average_G[ k ] = average_R[ k ] = 0;
                    }
                    for( vi = Math.Max( 0, i - brush_width / 2 ); vi < Math.Min( image.Height, i + brush_width / 2 ); vi++ )
                    {
                        for( vj = Math.Max( 0, j - brush_width / 2 ); vj < Math.Min( image.Width, j + brush_width / 2 ); vj++ )
                        {
                            pixel = image.GetPixel( vj, vi );
                            bin = ( pixel.R + pixel.G + pixel.B ) * nr_colors / ( 3 * 256 );
                            intensity_count[ bin ]++;
                            average_R[ bin ] += pixel.R;
                            average_G[ bin ] += pixel.G;
                            average_B[ bin ] += pixel.B;
                        }
                    }
                    bin = 0;
                    for( int k = 1; k < nr_colors; k++ )
                    {
                        if( intensity_count[ k ] > intensity_count[ bin ] )
                            bin = k;
                    }
                    dest.SetPixel( j, i, Color.FromArgb( average_R[ bin ] / intensity_count[ bin ], average_G[ bin ] / intensity_count[ bin ], average_B[ bin ] / intensity_count[ bin ] ) );
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
    }
}
