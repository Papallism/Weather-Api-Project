using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApiProject
{
    public partial class Form1 : Form
    {
        // Top secret API key
        private const string API_KEY = "5aebfe36d655409b83b110227212510";

        private FormSettings settingsForm = new();

        public Form1()
        {
            InitializeComponent();
        }

        // Function that calls the Weather API and gets the requested weather data
        private async Task<WeatherApiResponse> GetWeatherData()
        {
            var location = textBoxSearch.Text;
            var url = $"http://api.weatherapi.com/v1/current.json?key={API_KEY}&q={location}&aqi=no";

            using var client = new HttpClient();
            var response = await client.GetAsync(url);

            // Ensure success of the call or else return null
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<WeatherApiResponse>(responseString);
            }
            else
            {
                MessageBox.Show($"Something went wrong! Error {response.StatusCode}",
                                "Error");
                return null;
            }
        }

        // Function to display the weather data
        private async Task DisplayApiData()
        {
            var apiData = await GetWeatherData();

            labelLocationResult.Text = $"{apiData.Location.Name} ({apiData.Location.Region}), {apiData.Location.Country}";
            labelLocalTimeResult.Text = $"{apiData.Location.LocalTime}";
            // Display the temperature in the selected unit
            if (settingsForm.IsCelciusChecked)
            {
                labelTemperatureResult.Text = $"{apiData.Current.TempCelcius} °C ({apiData.Current.Condition.Text})";
            }
            else
            {
                labelTemperatureResult.Text = $"{apiData.Current.TempFahrenheit} °F ({apiData.Current.Condition.Text})";
            }
            // Locate and display the weather icon
            pictureBoxWeatherIcon.ImageLocation = $"http:{apiData.Current.Condition.Icon}";
        }

        // Function for clicking the "Search" button
        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            // Ensure that the search text box is not empty
            if (textBoxSearch.Text != "")
            {
                // Ensure that a preferred unit is selected in the settings form
                if (!settingsForm.IsCelciusChecked && !settingsForm.IsFahrenheitChecked)
                {
                    MessageBox.Show("Please select your preferred unit in \"Settings\" first",
                                    "No unit selected",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    // Handle calling and displaying the weather API data
                    try
                    {
                        await DisplayApiData();
                    }
                    catch (HttpRequestException)
                    {
                        MessageBox.Show("Location not found",
                                        "Bad Request",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a location to search for",
                                "Missing Value",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            settingsForm.ShowDialog();
        }
    }
}