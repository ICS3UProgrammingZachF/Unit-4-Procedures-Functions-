using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Picmanwalk
{
    public partial class PicManWalk : Form
    {
        public PicManWalk()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //generate the picture boxes
            GeneratePicBoxs();
        }

        private void PicureBox_Click(object sender, EventArgs e)
        {
            //cast the sneder object
            PictureBox tempPicMan = (PictureBox)sender;

            //wtite a mess to the console to check what picbox was clicked
            Console.WriteLine("Pictre box (" + tempPicMan.Location.X + ", " + tempPicMan.Location.Y + ") was clicked.");

            //local varibles and constants
            const byte MAX_WALK = 10;
            int walk = 1;

            // if than for the picturebox so the animatoin works
            while (walk < MAX_WALK + 1)
            {
                if (walk == 1)
                {
                    tempPicMan.Image = Properties.Resources.walk1;
                }
                else if (walk == 2)
                {
                    tempPicMan.Image = Properties.Resources.walk2;
                }
                else if (walk == 3)
                {
                    tempPicMan.Image = Properties.Resources.walk3;
                }
                else if (walk == 4)
                {
                    tempPicMan.Image = Properties.Resources.walk4;
                }
                else if (walk == 5)
                {
                    tempPicMan.Image = Properties.Resources.walk5;
                }
                else if (walk == 6)
                {
                    tempPicMan.Image = Properties.Resources.walk6;
                }
                else if (walk == 7)
                {
                    tempPicMan.Image = Properties.Resources.walk7;
                }
                else if (walk == 8)
                {
                    tempPicMan.Image = Properties.Resources.walk8;
                }
                else if (walk == 9)
                {
                    tempPicMan.Image = Properties.Resources.walk9;
                }
                else if (walk == 10)
                {
                    tempPicMan.Image = Properties.Resources.walk10;
                }

                //incemnet
                walk = walk + 1;

                //restests the picture box
                this.Refresh();

                //pauses the anition every millasecond
                Thread.Sleep(100);
            }
        }
        private void GeneratePicureBox(int x, int y)
        {
            
            //generates a new picture bkox and new points at locatoin (x, z) axes
            PictureBox tempPicMan = new PictureBox();
            Point pntPic = new System.Drawing.Point(x, y);

            //set location of he picture box
            tempPicMan.Location = pntPic;

            //assign the image to the picbox
            tempPicMan.Image = Properties.Resources.walk1;

            //strech the image to the picbox
            tempPicMan.SizeMode = PictureBoxSizeMode.StretchImage;

            //make the piucture box with and hight the same as the image
            tempPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            //add the event listender
            tempPicMan.Click += new System.EventHandler(PicureBox_Click);

            //add the picbox to the form
            Controls.Add(tempPicMan);
        }

        private void GeneratePicBoxs()
        {
            //creates picture boxs
            GeneratePicureBox(12, 12);
            GeneratePicureBox(507, 12);
            GeneratePicureBox(12, 309);
            GeneratePicureBox(507, 309);
        }
    }
}
