using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Photo newPhoto = new Photo("imagePath");

            var filters = new PhotoFilters();

            Action<Photo> filterDelegate = filters.Compress;
            filterDelegate += filters.Brighten;

            newPhoto.ApplyFilter(filterDelegate);
        }
    }
}
