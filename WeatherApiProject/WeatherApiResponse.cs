using Newtonsoft.Json;
using System;

namespace WeatherApiProject
{
    public class WeatherApiResponse
    {
        [JsonProperty("location")]
        public WeatherApiLocation Location { get; set; }

        [JsonProperty("current")]
        public WeatherApiCurrent Current { get; set; }
    }

    public class WeatherApiLocation
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("localtime")]
        public DateTime LocalTime { get; set; }
    }

    public class WeatherApiCurrent
    {
        [JsonProperty("temp_c")]
        public double TempCelcius { get; set; }

        [JsonProperty("temp_f")]
        public double TempFahrenheit { get; set; }

        [JsonProperty("condition")]
        public WeatherApiCondition Condition { get; set; }
    }

    public class WeatherApiCondition
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}