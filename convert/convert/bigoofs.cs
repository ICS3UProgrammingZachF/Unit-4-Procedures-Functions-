using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace convert
{
    public partial class bigoofs : Form
    {
      
        private SoundPlayer _soundPlayer;

        public bigoofs()
        {
            InitializeComponent();
           
            //playes music
             _soundPlayer = new SoundPlayer("Casual - NgelRodzTV Music.wav");
            _soundPlayer.Play();

            //hides lable
            lbl.Hide();
        }

        public double TempConverter(double celsius)
        {
            //decaler vierubles
            Double fahrenheit = 0;

            //convert the cesius to fahrenhig
            fahrenheit = celsius * (9) / (double)(5) + 32;

            //return function
            return fahrenheit;
        }

        private void btncovernt_Click(object sender, EventArgs e)
        {
            //local veriubles
            double usercelsius;

            //convers form a string to a double
            usercelsius = double.Parse(txt.Text);

            //calls the functoin
            usercelsius = TempConverter(usercelsius);

            //convers it back to a string
            lbl.Text = string.Format("{0:0.00}", usercelsius) + " f";

            //shows lables
            lbl.Show();
        }
    }
}
