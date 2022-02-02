using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace video29.Models
{
    public static class Images
    {
        public static List<ImagesItem> images = new List<ImagesItem>
        {
            new ImagesItem{Id=1,Title="Cloud",Link="1.jpg"},
            new ImagesItem{Id=2,Title="Cloud",Link="2.jpg"},
            new ImagesItem{Id=3,Title="Cloud",Link="3.jpg"},
            new ImagesItem{Id=3,Title="Cloud",Link="3.jpg"},
            new ImagesItem{Id=3,Title="Cloud",Link="3.jpg"},
            new ImagesItem{Id=3,Title="Cloud",Link="3.jpg"}
        };
        public static List<ImagesItem> GetImagesItems()=> images;
    }
    public class ImagesItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
    }
}
