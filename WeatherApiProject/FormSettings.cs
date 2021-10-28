using System.Windows.Forms;

namespace WeatherApiProject
{
    public partial class FormSettings : Form
    {
        // Read-only property for Celcius radio button
        public bool IsCelciusChecked
        {
            get
            {
                return radioButtonCelcius.Checked;
            }
        }

        // Read-only property for Fahrenheit radio button
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