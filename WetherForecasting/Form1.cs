using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WetherForecasting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ValidateWether();
        }

        private void txtAirTemp_TextChanged(object sender, EventArgs e)
        {
            this.ValidateWether();
        }

        private void txtWindChill_TextChanged(object sender, EventArgs e)
        {
            this.ValidateWether();
        }

        private void txtSnowFall_TextChanged(object sender, EventArgs e)
        {
            this.ValidateWether();
        }

        private void ValidateWether()
        {
            this.lblStatus.ForeColor = Color.Red;
            double airTemp = 0;
            if(!double.TryParse(this.txtAirTemp.Text, out airTemp) && !this.txtAirTemp.Text.Equals("-"))
            {
                this.lblStatus.Text = "Please enter a valid value for Air Temperature.";
                return;
            }
                
            double windChill = 0;
            if (!double.TryParse(this.txtWindChill.Text, out windChill) && !this.txtWindChill.Text.Equals("-"))
            {
                this.lblStatus.Text = "Please enter a valid value for Wind Chill.";
                return;
            }

            double snowFall = 0;
            if (!double.TryParse(this.txtSnowFall.Text, out snowFall) && !this.txtSnowFall.Text.Equals("-"))
            {
                this.lblStatus.Text = "Please enter a valid value for Snow Fall.";
                return;
            }

            if (airTemp <= -25 || windChill <= -35 || snowFall >= 6)
            {
                this.lblStatus.ForeColor = Color.Green;
                this.lblStatus.Text = "School is likely to be cancelled.";
            }
            else
            {
                this.lblStatus.ForeColor = Color.Blue;
                this.lblStatus.Text = "School is not likely to be cancelled.";
            }
        }

        
    }
}
