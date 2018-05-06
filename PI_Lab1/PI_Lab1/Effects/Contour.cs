using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Lab1.Effects
{
    class Contour : IEffect
    {
        private bool is_in_bounds( int val, int ll, int ul )
        {
            return ( val >= ll && val < ul );
        }

        public void apply( Bitmap image )
        {
            Bitmap contour = new Bitmap( image.Width, image.Height );
            int bg_color = 255;
            int neighbour_size = 1;
            bool[ , ] neighbour_mask = { { false, true, false }, { true, false, true }, { false, true, false } };
            int i, j, ni, nj;
            bool is_contour;
            int req_center_color = 0;
            Color pixel;
            for( i = 0; i < image.Height; i++ )
            {
                for( j = 0; j < image.Width; j++ )
                {
                    is_contour = false;
                    pixel = image.GetPixel( j, i );
                    if( pixel.R == req_center_color )
                    {
                        for( ni = -neighbour_size; ni <= neighbour_size && !is_contour; ni++ )
                        {
                            for( nj = -neighbour_size; nj <= neighbour_size && !is_contour; nj++ )
                            {
                                if( !neighbour_mask[ ni + neighbour_size, nj + neighbour_size ] )
                                    continue;
                                pixel = ( is_in_bounds( i + ni, 0, image.Height ) && is_in_bounds( j + nj, 0, image.Width ) ) ? image.GetPixel( j + nj, i + ni ) : Color.FromArgb( bg_color, bg_color, bg_color );
                                if( pixel.R != req_center_color )
                                {
                                    is_contour = true;
                                }
                            }
                        }
                    }
                    if( is_contour )
                    {
                        contour.SetPixel( j, i, Color.Black );
                    }
                    else
                    {
                        contour.SetPixel( j, i, Color.White );

                    }
                }
            }
            for( i = 0; i < image.Height; i++ )
            {
                for( j = 0; j < image.Width; j++ )
                {
                    image.SetPixel( j, i, contour.GetPixel( j, i ) );
                }
            }
        }
    }
}
