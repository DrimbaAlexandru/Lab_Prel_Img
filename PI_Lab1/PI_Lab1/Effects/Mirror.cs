using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Lab1.Effects
{
    class Mirror : IEffect
    {
        private int pivot_x = 0, pivot_y = 0;
        private double pivot_x_rp = 0, pivot_y_rp = 0;
        private double dir_x = 1, dir_y = 0;

        public void setParameters( double pivot_x_rel_pos, double pivot_y_rel_pos, double angle )
        {
            this.pivot_x_rp = pivot_x_rel_pos;
            this.pivot_y_rp = pivot_y_rel_pos;
            dir_x = Math.Cos( -angle );
            dir_y = Math.Sin( -angle );
        }

        public int limit( int val, int ll, int ul )
        {
            return ( val < ll ) ? ll : ( val >= ul ) ? ul - 1 : val;
        }

        public Color getColor( Bitmap image, double x, double y )
        {
            Color tl, tr, bl, br;
            double x_prop = 1.0 - ( x - Math.Floor( x ) );
            double y_prop = 1.0 - ( y - Math.Floor( y ) );

            int r, g, b;

            tl = image.GetPixel( limit( ( int )x, 0, image.Width ), limit( ( int )y, 0, image.Height ) );
            tr = image.GetPixel( limit( ( int )x + 1, 0, image.Width ), limit( ( int )y, 0, image.Height ) );
            bl = image.GetPixel( limit( ( int )x, 0, image.Width ), limit( ( int )y + 1, 0, image.Height ) );
            br = image.GetPixel( limit( ( int )x + 1, 0, image.Width ), limit( ( int )y + 1, 0, image.Height ) );

            r = ( int )( ( tl.R * x_prop + tr.R * ( 1.0 - x_prop ) ) * y_prop + ( bl.R * x_prop + br.R * ( 1.0 - x_prop ) ) * ( 1.0 - y_prop ) );
            g = ( int )( ( tl.G * x_prop + tr.G * ( 1.0 - x_prop ) ) * y_prop + ( bl.G * x_prop + br.G * ( 1.0 - x_prop ) ) * ( 1.0 - y_prop ) );
            b = ( int )( ( tl.B * x_prop + tr.B * ( 1.0 - x_prop ) ) * y_prop + ( bl.B * x_prop + br.B * ( 1.0 - x_prop ) ) * ( 1.0 - y_prop ) );

            return Color.FromArgb( r, g, b );
        }

        public Tuple<double, double> getMirroredPoint( double x, double y )
        {
            Tuple<double, double> intersection = getFoot( pivot_x, pivot_y, dir_x, dir_y, x, y );
            return new Tuple<double, double>( x + 2 * ( intersection.Item1 - x ), y + 2 * ( intersection.Item2 - y ) );
        }

        public Tuple<double, double> getFoot( double x0, double y0, double vx, double vy, double x, double y )
        {
            double dotProduct = ( x - x0 ) * vx + ( y - y0 ) * vy;
            return new Tuple<double, double>( x0 + dotProduct * vx, y0 + dotProduct * vy );
        }

        public void apply( Bitmap image )
        {
            int i, j;

            pivot_x = ( int )( image.Width * ( pivot_x_rp + 1 ) / 2 );
            pivot_y = ( int )( image.Height * ( pivot_y_rp + 1 ) / 2 );

            if( Math.Abs( dir_x ) <= 0.0001 )
            {
                int xs, xe;
                if( pivot_x < image.Width / 2 )
                {
                    xs = 0;
                    xe = pivot_x;
                }
                else
                {
                    xs = pivot_x;
                    xe = image.Width;
                }
                for( i = 0; i < image.Height; i++ )
                {
                    for( j = xs; j < xe; j++ )
                    {
                        image.SetPixel( j, i, getColor( image, 2 * pivot_x - j, i ) );
                    }
                }
            }
            else if( Math.Abs( dir_y ) <= 0.0001 )
            {
                int ys, ye;
                if( pivot_y < image.Height / 2 )
                {
                    ys = 0;
                    ye = pivot_y;
                }
                else
                {
                    ys = pivot_y;
                    ye = image.Height;
                }
                for( i = ys; i < ye; i++ )
                {
                    for( j = 0; j < image.Width; j++ )
                    {
                        image.SetPixel( j, i, getColor( image, j, 2 * pivot_y - i ) );
                    }
                }
            }
            else
            {
                Tuple<double, double> p1, p2;
                Tuple<Tuple<double, double>, Tuple<double, double>>[] feet = new Tuple<Tuple<double, double>, Tuple<double, double>>[ 4 ];
                Tuple<Tuple<double, double>, Tuple<double, double>> minimum = null;
                double dist_min = 0;

                feet[ 0 ] = new Tuple<Tuple<double, double>, Tuple<double, double>>( getFoot( pivot_x, pivot_y, dir_x, dir_y, 0, 0 ), new Tuple<double, double>( 0, 0 ) );
                feet[ 1 ] = new Tuple<Tuple<double, double>, Tuple<double, double>>( getFoot( pivot_x, pivot_y, dir_x, dir_y, image.Width - 1, 0 ), new Tuple<double, double>( image.Width - 1, 0 ) );
                feet[ 2 ] = new Tuple<Tuple<double, double>, Tuple<double, double>>( getFoot( pivot_x, pivot_y, dir_x, dir_y, 0, image.Height - 1 ), new Tuple<double, double>( 0, image.Height - 1 ) );
                feet[ 3 ] = new Tuple<Tuple<double, double>, Tuple<double, double>>( getFoot( pivot_x, pivot_y, dir_x, dir_y, image.Width - 1, image.Height - 1 ), new Tuple<double, double>( image.Width - 1, image.Height - 1 ) );

                foreach( Tuple<Tuple<double, double>, Tuple<double, double>> p in feet )
                {
                    p1 = p.Item1;
                    p2 = p.Item2;
                    if( p1.Item1 >= 0 && p1.Item1 < image.Width && p1.Item2 >= 0 && p1.Item2 < image.Height )
                    {
                        if( minimum == null )
                        {
                            minimum = p;
                            dist_min = Math.Pow( minimum.Item1.Item1 - minimum.Item2.Item1, 2 ) + Math.Pow( minimum.Item1.Item2 - minimum.Item2.Item2, 2 );
                        }
                        else
                        {
                            double dist = Math.Pow( p.Item1.Item1 - p.Item2.Item1, 2 ) + Math.Pow( p.Item1.Item2 - p.Item2.Item2, 2 );
                            if( dist < dist_min )
                            {
                                minimum = p;
                                dist_min = dist;
                            }
                        }
                    }
                }

                if( minimum == feet[ 0 ] || minimum == feet[ 2 ] )
                {
                    for( i = 0; i < image.Height; i++ )
                    {
                        int lim = ( int )Math.Min( pivot_x + ( 0.0 + i - pivot_y ) / dir_y * dir_x, image.Width );
                        for( j = 0; j < lim; j++ )
                        {
                            p1 = getMirroredPoint( j, i );
                            image.SetPixel( j, i, getColor( image, p1.Item1, p1.Item2 ) );
                        }
                    }
                }

                if( minimum == feet[ 1 ] || minimum == feet[ 3 ] )
                {
                    for( i = 0; i < image.Height; i++ )
                    {
                        int lim = ( int )Math.Max( pivot_x + ( 0.0 + i - pivot_y ) / dir_y * dir_x, 0 );
                        for( j = lim; j < image.Width; j++ )
                        {
                            p1 = getMirroredPoint( j, i );
                            image.SetPixel( j, i, getColor( image, p1.Item1, p1.Item2 ) );
                        }
                    }
                }
            }
        }
    }
}