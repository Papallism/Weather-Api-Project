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

        public Form1()
        {
            InitializeComponent();
        }

        public async Task<WeatherApiResponse> GetWeatherData()
        {
            var location = textBoxSearch.Text;
            var url = $"http://api.weatherapi.com/v1/current.json?key={API_KEY}&q={location}&aqi=no";

            using var client = new HttpClient();
            var response = await client.GetAsync(url);
            var responseString = await response.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<WeatherApiResponse>(responseString);

            return responseObject;
        }
    }
}
