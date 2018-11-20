using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace photo_album
{
    class PhotoAlbum
    {
        private int _number_of_pages;

        public PhotoAlbum()
        {
            _number_of_pages = 16;
        }

        public PhotoAlbum(int i)
        {
            _number_of_pages = i;
        }

        public int GetNumberOfPages()
        {
            return _number_of_pages;
        }
    }

    class BigPhotoAlbum : PhotoAlbum
    {
        private PhotoAlbum pa;

        public BigPhotoAlbum()
        {
            pa = new PhotoAlbum(64);
        }

        public new int GetNumberOfPages()
        {
            return pa.GetNumberOfPages();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PhotoAlbum pa1 = new PhotoAlbum();
            PhotoAlbum pa2 = new PhotoAlbum(24);
            BigPhotoAlbum pa3 = new BigPhotoAlbum();
            Console.WriteLine(pa1.GetNumberOfPages());
            Console.WriteLine(pa2.GetNumberOfPages());
            Console.WriteLine(pa3.GetNumberOfPages());
            Console.ReadLine();
        }
    }
}
