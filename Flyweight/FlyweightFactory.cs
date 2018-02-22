using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flyweight
{
    class FlyweightFactory
    {
        Dictionary<int, Image> images = new Dictionary<int, Image>();
        static Random shuffle = new Random();

        private Image GetImage(int key)
        {
            Image image;

            switch (key)
            {
                case 1:
                    image = Image.FromFile(@"C:\Users\izba_cr95\source\repos\Flyweight\Flyweight\images\Fotolia_85723666_XS.jpg");
                    images.Add(key, image);
                    return image;
                case 2:
                    image = Image.FromFile(@"C:\Users\izba_cr95\source\repos\Flyweight\Flyweight\images\Mops.jpg");
                    images.Add(key, image);
                    return image;
                case 3:
                    image = Image.FromFile(@"C:\Users\izba_cr95\source\repos\Flyweight\Flyweight\images\mops_53201193_XS.jpg");
                    images.Add(key, image);
                    return image;
                case 4:
                    image = Image.FromFile(@"C:\Users\izba_cr95\source\repos\Flyweight\Flyweight\images\Psy rasy Mops.jpg");
                    images.Add(key, image);
                    return image;
            }
            return null;
        }

        public void loadFromList(PictureBox picture)
        {
            int id = shuffle.Next(1, 5);

            if (images.ContainsKey(id))
            {
                picture.BackgroundImage = images[id];
            }
            else
            {
                picture.BackgroundImage = GetImage(id);
            }
        }


    }
}
