using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ImgurDesktop
{
    public class Poster
    {
        string name;
        string img;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Img
        {
            get
            {
                return img;
            }

            set
            {
                img = value;
            }
        }

        public Poster(string FilmName, string FilmPosterPath)
        {
            Name = FilmName;
            Img = FilmPosterPath;
        }
    }
}
