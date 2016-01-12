using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Klienten.WeatherPrediction;

namespace Klienten
{
    public partial class WeatherSide : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PredictWeatherBtn_Click(object sender, EventArgs e)
        {
            WeatherPrediction.WeatherSoapClient weatherService = new WeatherSoapClient();
            ResultLabel.Text = weatherService.WeatherForecast();

        }
    }
}