using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApiProject
{
    public partial class Form1 : Form
    {
        private const string API_KEY = "5aebfe36d655409b83b110227212510";
        private FormSettings settingsForm = new();

        public Form1()
        {
            InitializeComponent();
        }

        private async Task<WeatherApiResponse> GetWeatherData()
        {
            var location = textBoxSearch.Text;
            var url = $"http://api.weatherapi.com/v1/current.json?key={API_KEY}&q={location}&aqi=no";

            using var client = new HttpClient();
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<WeatherApiResponse>(responseString);

            return responseObject;
        }

        private async Task DisplayApiData()
        {
            var apiData = await GetWeatherData();

            labelLocationResult.Text = $"{apiData.Location.Name} ({apiData.Location.Region}), {apiData.Location.Country}";
            labelLocalTimeResult.Text = $"{apiData.Location.LocalTime}";
            if (settingsForm.IsCelciusChecked)
            {
                labelTemperatureResult.Text = $"{apiData.Current.TempCelcius} °C ({apiData.Current.Condition.Text})";
            }
            else
            {
                labelTemperatureResult.Text = $"{apiData.Current.TempFahrenheit} °F ({apiData.Current.Condition.Text})";
            }
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                try
                {
                    await DisplayApiData();
                }
                catch (HttpRequestException exc)
                {
                    MessageBox.Show(exc.Message, "Bad Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a location to search for", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            settingsForm.ShowDialog();
        }
    }
}
