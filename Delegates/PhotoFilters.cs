using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class PhotoFilters
    {
        public void Compress(Photo photo)
        {
            Console.WriteLine("Compressing image...");
        }

        public void Sharpen(Photo photo)
        {
            Console.WriteLine("Sharpening image...");
        }

        public void Brighten(Photo photo)
        {
            Console.WriteLine("Increasing image brightness...");
        }
    }
}
