using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Lab1.Effects
{
    public class BlendImages : IEffect
    {
        private List<Bitmap> others = null;
        private List<Tuple<int, int>> positions = null;

        private int limit( int val, int ll, int ul )
        {
            return ( val < ll ) ? ll : ( val >= ul ) ? ul - 1 : val;
        }

        private byte fromDoubleColor( double c )
        {
            return ( ( c < 0 ) ? ( byte )0 : ( ( c > 255 ) ? ( byte )255 : ( byte )c ) );
        }

        public void setParameters( List<Bitmap> images, List<Tuple<int,int>> positions )
        {
            others = images;
            this.positions = positions;
        }

        public void apply( Bitmap image )
        {
            if( others == null || positions==null )
                throw new ImageProcessingException( "Images or positions cannot be null" );
            if( others.Count != positions.Count )
                throw new ImageProcessingException( "Count of images and positions must be the same" );

            int i, j;
            double r, g, b;
            Color pixel1, pixel2;

            for( i = 0; i < image.Height; i++ )
            {
                for( j = 0; j < image.Width; j++ )
                {
                    pixel1 = image.GetPixel( j, i );
                    r = g = b = 0;

                    for( int k = 0; k < others.Count; k++ )
                    {
                        pixel2 = others[ k ].GetPixel( limit( j - positions[ k ].Item1, 0, others[ k ].Width ), limit( i - positions[ k ].Item2, 0, others[ k ].Height ) );
                        r += pixel2.R;
                        g += pixel2.G;
                        b += pixel2.B;
                    }

                    r += pixel1.R;
                    g += pixel1.G;
                    b += pixel1.B;

                    r *= 1.0 / ( 1 + others.Count );
                    g *= 1.0 / ( 1 + others.Count );
                    b *= 1.0 / ( 1 + others.Count );

                    image.SetPixel( j, i, Color.FromArgb( fromDoubleColor( r ), fromDoubleColor( g ), fromDoubleColor( b ) ) );
                }
            }

            /*//everything
            for( i = 0; i < image.Height; i++ )
            {
                for( j = 0; j < image.Width; j++ )
                {
                    pixel1 = image.GetPixel( j, i );
                    pixel2 = other.GetPixel( limit( j - pos_x, 0, other.Width ), limit( i - pos_y, 0, other.Height ) );
                    r = fromDoubleColor( pixel1.R + ( pixel2.R - color_offset ) * opacity );
                    g = fromDoubleColor( pixel1.G + ( pixel2.G - color_offset ) * opacity );
                    b = fromDoubleColor( pixel1.B + ( pixel2.B - color_offset ) * opacity );
                    image.SetPixel( j, i, Color.FromArgb( r, g, b ) );
                }
            }
            */

        }
    }
}