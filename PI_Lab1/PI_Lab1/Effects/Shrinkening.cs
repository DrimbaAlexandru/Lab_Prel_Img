using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Lab1.Effects
{
    class Thin : IEffect
    {
        private bool isInBounds( int val, int ll, int ul )
        {
            return ( val >= ll && val < ul );
        }

        public void apply( Bitmap image )
        {
            //Bitmap contour = ( Bitmap )image.Clone();
            int i, j, vi, vj, nv, nt;
            int object_color = 0;
            Tuple<int, int>[] neighbours = { new Tuple<int, int>( -1, 1 ), new Tuple<int, int>( -1, 0 ), new Tuple<int, int>( -1, -1 ),
                                             new Tuple<int, int>( 0, -1 ), new Tuple<int, int>( 1, -1 ), new Tuple<int, int>( 1, 0 ),
                                             new Tuple<int, int>( 1, 1 ), new Tuple<int, int>( 0, 1 ) };
            List<Tuple<int, int>> to_remove = new List<Tuple<int, int>>();
            bool modified = true;
            Color pixel;
            int color;
            int other_color;
            //new Contour().apply( contour );

            while( modified )
            {
                modified = false;
                for( i = 0; i < image.Height; i++ )
                {
                    for( j = 0; j < image.Width; j++ )
                    {
                        pixel = image.GetPixel( j, i );
                        if( pixel.R == object_color )
                        {
                            nv = 0;
                            nt = 0;
                            for( int k = 0; k < neighbours.Length; k++ )
                            {
                                vi = i + neighbours[ k ].Item1;
                                vj = j + neighbours[ k ].Item2;
                                if( ( isInBounds( vi, 0, image.Height ) ) && isInBounds( vj, 0, image.Width ) && image.GetPixel( vj, vi ).R == object_color )
                                {
                                    nv++;
                                }
                            }
                            for( int k = 0; k < neighbours.Length; k++ )
                            {
                                vi = i + neighbours[ k ].Item1;
                                vj = j + neighbours[ k ].Item2;
                                color = ( isInBounds( vi, 0, image.Height ) && isInBounds( vj, 0, image.Width ) ) ? image.GetPixel( vj, vi ).R : 255 - object_color;
                                
                                vi = i + neighbours[ ( k + 1 ) % neighbours.Length ].Item1;
                                vj = j + neighbours[ ( k + 1 ) % neighbours.Length ].Item2;
                                other_color = ( isInBounds( vi, 0, image.Height ) && isInBounds( vj, 0, image.Width ) ) ? image.GetPixel( vj, vi ).R : 255 - object_color;

                                nt += ( color!=other_color ) ? 1 : 0;
                            }
                            if( 2 <= nv && nv <= 6 && nt == 2 )
                            {
                                to_remove.Add( new Tuple<int, int>( j, i ) );
                                //image.SetPixel( j,i, Color.FromArgb( 255 - object_color, 255 - object_color, 255 - object_color ) );
                                modified = true;
                            }
                        }
                    }
                }

                foreach( var p in to_remove )
                {
                    image.SetPixel( p.Item1, p.Item2, Color.FromArgb( 255 - object_color, 255 - object_color, 255 - object_color ) );
                }
                to_remove.Clear();
            }
        }
    }
}
