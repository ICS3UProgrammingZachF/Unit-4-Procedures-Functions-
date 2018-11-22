using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolCylineder
{
    public partial class VolOfCylinder : Form
    {
        public VolOfCylinder()
        {
            InitializeComponent();
            lblawanser.Hide();
            pic.Hide();
        }

        public double CalculateVolume(double Radius, double Hight )
        {
            //local veruble 
            Double volume = 0;

            //calulate the vloume
            volume = Math.PI * Math.Pow(Radius, 2) * Hight;

            //return the vloum to the functoin
            return volume;
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            //local veruble
            double userRaduis, userHight, userVolume;

            //convert form a string to a double
            userRaduis = double.Parse(txtradius.Text);
            userHight = double.Parse(txthight.Text);

            //call the procedure
            userVolume = CalculateVolume(userRaduis, userHight);

            //covert it to the lable
            lblawanser.Text ="The volume of the cylinder is "+ string.Format( "{0:0.00}", userVolume) + " Cm³";

            //show lable
            lblawanser.Show();
            pic.Show();
        }
    }
}
