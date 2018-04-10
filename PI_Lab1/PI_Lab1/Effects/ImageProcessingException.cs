using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Lab1.Effects
{
    public class ImageProcessingException : Exception
    {
        public ImageProcessingException()
            : base()
        {
        }

        public ImageProcessingException( String message )
            : base( message )
        {
        }
    }
}
