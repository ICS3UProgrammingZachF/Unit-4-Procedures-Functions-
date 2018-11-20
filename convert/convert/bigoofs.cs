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
           
             _soundPlayer = new SoundPlayer("Casual - NgelRodzTV Music.wav");
            _soundPlayer.Play();
        }

        public void TempConverter(double celsius)
        {
            //decaler vierubles
            double fahrenheit = 0;
            //convert the cesius to fahrenhig
            fahrenheit = celsius * (9) / (double)(5) + 32;
        }

        private void btncovernt_Click(object sender, EventArgs e)
        {
            double usercelsius = 0;

            this.TempConverter(usercelsius);


        }
    }
}
