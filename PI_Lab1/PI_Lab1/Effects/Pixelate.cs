using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Lab1.Effects
{
    class Pixelate : IEffect
    {
        Rectangle rectangle;
        Int32 pixelateSize;

        public void setParameters(Rectangle rectangle, Int32 pixelateSize)
        {
            this.rectangle = rectangle;
            this.pixelateSize = pixelateSize;
        }

        public void apply(Bitmap image)
        {
            Bitmap pixelated = (Bitmap)image.Clone();
            
            for (Int32 xx = rectangle.X; xx < rectangle.X + rectangle.Width && xx < image.Width; xx += pixelateSize)
            {
                for (Int32 yy = rectangle.Y; yy < rectangle.Y + rectangle.Height && yy < image.Height; yy += pixelateSize)
                {
                    Int32 offsetX = pixelateSize / 2;
                    Int32 offsetY = pixelateSize / 2;
                    
                    while (xx + offsetX >= image.Width) offsetX--;
                    while (yy + offsetY >= image.Height) offsetY--;
                    
                    Color pixel = pixelated.GetPixel(xx + offsetX, yy + offsetY);
                    
                    for (Int32 x = xx; x < xx + pixelateSize && x < image.Width; x++)
                        for (Int32 y = yy; y < yy + pixelateSize && y < image.Height; y++)
                            pixelated.SetPixel(x, y, pixel);
                }
            }
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    image.SetPixel(j, i, pixelated.GetPixel(j, i));
                }
            }
        }
    }
}
