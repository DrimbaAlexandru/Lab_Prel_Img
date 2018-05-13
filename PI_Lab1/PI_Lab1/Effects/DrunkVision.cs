using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Lab1.Effects
{
    class DrunkVision:IEffect
    {
        private int nr_eyes = 1, drunkenness = 0;

        public void setParameters( int eyes, int drunk )
        {
            nr_eyes = eyes;
            drunkenness = drunk;
        }

        public void apply( Bitmap image )
        {
            Bitmap original = ( Bitmap )image.Clone();
            Random rng = new Random();
            BlendImages bi = new BlendImages();
            List<Bitmap> images = new List<Bitmap>();
            List<Tuple<int, int>> positions = new List<Tuple<int, int>>();

            for( int i = 1; i < nr_eyes; i++ )
            {
                images.Add( original );
                positions.Add( new Tuple<int, int>( rng.Next( -drunkenness * image.Width / 250, drunkenness * image.Width / 250 ), rng.Next( -drunkenness * image.Width / 4000, drunkenness * image.Width / 4000 ) ) );
            }

            bi.setParameters( images, positions );
            bi.apply( image );
        }
    }
}
