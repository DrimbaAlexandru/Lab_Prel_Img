using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Lab1.Effects
{
    class Contour_Traversal
    {
        public static List<List<Tuple<int, int>>> get_contour_description( Bitmap image )
        {
            List<List<Tuple<int, int>>> descr = new List<List<Tuple<int, int>>>();
            int i, j;
            int pozx, pozy;
            int contour_color = 0;
            Color pixel;
            Stack<Tuple<int, int>> to_visit = new Stack<Tuple<int, int>>();
            Bitmap imageCopy = (Bitmap)image.Clone();
            for( i = 0; i < imageCopy.Height; i++ )
            {
                for( j = 0; j < imageCopy.Width; j++ )
                {
                    pixel = imageCopy.GetPixel( j, i );
                    if( pixel.R == contour_color )
                    {
                        List<Tuple<int, int>> contour = new List<Tuple<int, int>>();
                        to_visit.Push( new Tuple<int, int>( j, i ) );
                        imageCopy.SetPixel( j, i, Color.FromArgb( 255 - contour_color, 255 - contour_color, 255 - contour_color ) );

                        while( to_visit.Count > 0 )
                        {
                            pozx = to_visit.Peek().Item1;
                            pozy = to_visit.Peek().Item2;
                            contour.Add( to_visit.Pop() );
                            for( int y = Math.Max( 0, pozy - 1 ); y <= Math.Min( pozy + 1, imageCopy.Height - 1 ); y++ )
                            {
                                for( int x = Math.Max( 0, pozx - 1 ); x <= Math.Min( pozx + 1, imageCopy.Width - 1 ); x++ )
                                {
                                    pixel = imageCopy.GetPixel( x, y );
                                    if( pixel.R == contour_color )
                                    {
                                        to_visit.Push( new Tuple<int, int>( x, y ) );
                                        imageCopy.SetPixel( x, y, Color.FromArgb( 255 - contour_color, 255 - contour_color, 255 - contour_color ) );
                                    }
                                }
                            }
                        }
                        descr.Add( contour );
                    }
                }
            }

            return descr;
        }
    }
}
