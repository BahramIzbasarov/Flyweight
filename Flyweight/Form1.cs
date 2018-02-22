using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flyweight
{
    public partial class Form1 : Form
    {
        FlyweightFactory image = new FlyweightFactory();
        public Form1()
        {
            InitializeComponent();
            Shuffle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shuffle();
        }

        private void Shuffle()
        {
            image.loadFromList(pictureBox1);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            image.loadFromList(pictureBox2);
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            image.loadFromList(pictureBox3);
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            image.loadFromList(pictureBox4);
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
