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
        public static Color[] colors = {Color.White, Color.Red, Color.Green, Color.Blue,Color.Yellow, Color.Black};

        private Bitmap eggBase;
        private Bitmap[] eggMid;
        private Bitmap[] eggTop;
        private Bitmap[] eggBot;
        private ArrayScroller<Bitmap> eggMidScroller;
        private ArrayScroller<Bitmap> eggTopScroller;
        private ArrayScroller<Bitmap> eggBotScroller;
        private ArrayScroller<Color> eggBaseColorScroller;
        private ArrayScroller<Color> eggMidColorScroller;
        private ArrayScroller<Color> eggTopColorScroller;
        private ArrayScroller<Color> eggBotColorScroller;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load all the images
            eggBase = new Bitmap("img/base/base.png");
            panelEgg.BackgroundImage = eggBase;
            

            string[] files = Directory.GetFiles("img/mid/");
            Bitmap[] temp = new Bitmap[files.Length];

            for(int i = 0; i < files.Length; i++)
            {
                temp[i] = new Bitmap(files[i]);
            }

            eggMidScroller = new ArrayScroller<Bitmap>(temp);
            pictureBoxEggMid.Image = eggMidScroller.Current();

            //Have to create 2 copies of each top/bot image cause pictureboxes cant reference same image (causes exception)
            files = Directory.GetFiles("img/end/");
            temp = new Bitmap[files.Length];
            Bitmap[] temp2 = new Bitmap[files.Length];

            for (int i = 0; i < files.Length; i++)
            {
                temp[i] = new Bitmap(files[i]);
                Bitmap flipped = new Bitmap(files[i]);
                flipped.RotateFlip(RotateFlipType.Rotate180FlipX); //have to flip bottom part cause it uses images built for top part
                temp2[i] = flipped;
            }

            eggTopScroller = new ArrayScroller<Bitmap>(temp);
            eggBotScroller = new ArrayScroller<Bitmap>(temp2);
            pictureBoxEggTop.Image = eggTopScroller.Current();
            pictureBoxEggBot.Image = eggBotScroller.Current();


            eggBaseColorScroller = new ArrayScroller<Color>(colors);
            eggMidColorScroller = new ArrayScroller<Color>(colors);
            eggTopColorScroller = new ArrayScroller<Color>(colors);
            eggBotColorScroller = new ArrayScroller<Color>(colors);


            //change base egg color from white to next
            ChangeColor((Bitmap)panelEgg.BackgroundImage, eggBaseColorScroller.Next());
            panelEgg.Invalidate();
        }

        private void buttonEggBase_Click(object sender, EventArgs e)
        {
            ChangeColor((Bitmap)panelEgg.BackgroundImage, eggBaseColorScroller.Next());
            panelEgg.Invalidate();
        }

        public void ChangeColor(Bitmap bitmap, Color newColor)
        {
            Color originalColor;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    originalColor = bitmap.GetPixel(i, j);
                    if (originalColor.A > 150)
                    {
                        bitmap.SetPixel(i, j, newColor);
                    }
                    else
                    {
                        bitmap.SetPixel(i, j, originalColor);
                    }
                }
            }
        }

        private void buttonEggTopPattern_Click(object sender, EventArgs e)
        {
            pictureBoxEggTop.Image = eggTopScroller.Next();
            ChangeColor((Bitmap)pictureBoxEggTop.Image, eggTopColorScroller.Current());
            pictureBoxEggTop.Invalidate();
        }

        private void buttonEggMidPattern_Click(object sender, EventArgs e)
        {
            pictureBoxEggMid.Image = eggMidScroller.Next();
            ChangeColor((Bitmap)pictureBoxEggMid.Image, eggMidColorScroller.Current());
            pictureBoxEggMid.Invalidate();
        }

        private void buttonEggBotPattern_Click(object sender, EventArgs e)
        {
            pictureBoxEggBot.Image = eggBotScroller.Next();
            ChangeColor((Bitmap)pictureBoxEggBot.Image, eggBotColorScroller.Current());
            pictureBoxEggBot.Invalidate();
        }

        private void buttonEggTopColor_Click(object sender, EventArgs e)
        {
            ChangeColor((Bitmap)pictureBoxEggTop.Image, eggTopColorScroller.Next());
            pictureBoxEggTop.Invalidate();
        }

        private void buttonEggMidColor_Click(object sender, EventArgs e)
        {
            ChangeColor((Bitmap)pictureBoxEggMid.Image, eggMidColorScroller.Next());
            pictureBoxEggMid.Invalidate();
        }

        private void buttonEggBotColor_Click(object sender, EventArgs e)
        {
            ChangeColor((Bitmap)pictureBoxEggBot.Image, eggBotColorScroller.Next());
            pictureBoxEggBot.Invalidate();
        }
    }
}
