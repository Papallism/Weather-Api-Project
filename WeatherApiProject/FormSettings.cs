using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApiProject
{
    public partial class FormSettings : Form
    {
        public bool IsCelciusChecked
        {
            get
            {
                return radioButtonCelcius.Checked;
            }
        }

        public bool IsFahrenheitChecked
        {
            get
            {
                return radioButtonFahrenheit.Checked;
            }
        }

        public FormSettings()
        {
            InitializeComponent();
        }
    }
}
