using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Lab1.Effects
{
    class Skeletization : IEffect
    {
        private bool isLocalMaximum( int[ , ] mat, int i, int j )
        {
            return ( mat[ i - 1, j - 1 ] <= mat[ i, j ] )
                && ( mat[ i - 1, j ] <= mat[ i, j ] )
                && ( mat[ i - 1, j + 1 ] <= mat[ i, j ] )
                && ( mat[ i, j - 1 ] <= mat[ i, j ] )
                && ( mat[ i, j + 1 ] <= mat[ i, j ] )
                && ( mat[ i + 1, j - 1 ] <= mat[ i, j ] )
                && ( mat[ i + 1, j ] <= mat[ i, j ] )
                && ( mat[ i + 1, j + 1 ] <= mat[ i, j ] );
        }

        public void apply( Bitmap image )
        {
            Bitmap contour = ( Bitmap )image.Clone();
            int[ , ] distances = new int[ image.Height, image.Width ];
            int i, j, vi, vj, k;
            int max_dist = Math.Max( image.Width, image.Height );
            int contour_color = 0;
            List<Tuple<int, int>> current_distance = new List<Tuple<int, int>>();
            bool modified = true;

            new Contour().apply( contour );

            for( i = 0; i < contour.Height; i++ )
            {
                for( j = 0; j < contour.Width; j++ )
                {
                    if( contour.GetPixel( j, i ).R == contour_color )
                    {
                        distances[ i, j ] = 0;
                        current_distance.Add( new Tuple<int, int>( i, j ) );
                    }
                    else
                    {
                        distances[ i, j ] = max_dist;
                    }
                }
            }

            while( modified )
            {
                modified = false;
                for( i = 0; i < image.Height; i++ )
                {
                    for( j = 0; j < image.Width; j++ )
                    {
                        k = distances[ i, j ];
                        for( vi = Math.Max( 0, i - 1 ); vi <= Math.Min( image.Height - 1, i + 1 ); vi++ )
                        {
                            for( vj = Math.Max( 0, j - 1 ); vj <= Math.Min( image.Width - 1, j + 1 ); vj++ )
                            {
                                k = Math.Min( k, distances[ vi, vj ] + 1 );
                            }
                        }
                        if( distances[ i, j ] != k )
                        {
                            modified = true;
                            distances[ i, j ] = k;
                        }
                    }
                }
            }

            for( i = 0; i < contour.Height; i++ )
            {
                contour.SetPixel( 0, i, Color.FromArgb( 255, 255, 255 ) );
                contour.SetPixel( contour.Width - 1, i, Color.FromArgb( 255, 255, 255 ) );
            }
            for( j = 0; j < contour.Width; j++ )
            {
                contour.SetPixel( j, 0, Color.FromArgb( 255, 255, 255 ) );
                contour.SetPixel( j, contour.Height - 1, Color.FromArgb( 255, 255, 255 ) );
            }

            for( i = 1; i < image.Height - 1; i++ )
            {
                for( j = 1; j < image.Width - 1; j++ )
                {
                    int color;
                    color = ( image.GetPixel( j, i ).R == 0 && isLocalMaximum( distances, i, j ) ) ? 0 : 255; //Is local maximum and inside object
                    //color = Math.Max( 0, 255 - distances1[ i, j ] * 16 );
                    //image.SetPixel( j, i, Color.FromArgb( 255 - distances[ i, j ], 255 - distances[ i, j ], 255 - distances[ i, j ] ) );
                    image.SetPixel( j, i, Color.FromArgb( color, color, color ) );
                }
            }
        }
    }
}