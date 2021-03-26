using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class Photo
    {
        //public delegate void Filter(Photo photo);
        //System allows us to use prebuilt delegates, so we will use that instead of declaring our own:
        private string Path { get; set; }

        public Photo(string path)
        {
            Path = path;
        }

        
        //here
        public void ApplyFilter(Action<Photo> filter)
        {
            filter(this);
        }
    }
}
