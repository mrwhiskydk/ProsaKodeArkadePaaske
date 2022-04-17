using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProsaKodeArkadePåske
{
    public partial class Form1 : Form
    {
        private Bitmap eggBase;
        private Bitmap[] eggMid;
        private Bitmap[] eggTop;
        private Bitmap[] eggBot;
        private ArrayScroller<Bitmap> eggMidScroller;
        private ArrayScroller<Bitmap> eggTopScroller;
        private ArrayScroller<Bitmap> eggBotScroller;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load all the images
            eggBase = new Bitmap("img/base/base.png");
            //pictureBoxEggBase.Image = eggBase;
            panelEgg.BackgroundImage = eggBase;

            string[] files = Directory.GetFiles("img/mid/");
            Bitmap[] temp = new Bitmap[files.Length];

            for(int i = 0; i < files.Length; i++)
            {
                temp[i] = new Bitmap(files[i]);
            }

            eggMidScroller = new ArrayScroller<Bitmap>(temp);

            //Have to create 2 copies of each top/bot image cause pictureboxes cant reference same image (causes exception)
            files = Directory.GetFiles("img/end/");
            temp = new Bitmap[files.Length];
            Bitmap[] temp2 = new Bitmap[files.Length];

            for (int i = 0; i < files.Length; i++)
            {
                temp[i] = new Bitmap(files[i]);
                temp2[i] = new Bitmap(files[i]);
            }

            eggTopScroller = new ArrayScroller<Bitmap>(temp);
            eggBotScroller = new ArrayScroller<Bitmap>(temp2);

        }

        private void buttonEggBase_Click(object sender, EventArgs e)
        {
            Graphics graphics = Graphics.FromImage(eggBase);
            graphics.DrawImage(eggBase, 0, 0);
        }
    }
}
