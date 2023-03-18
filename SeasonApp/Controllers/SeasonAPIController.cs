using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SeasonApp.Controllers
{
    public class SeasonAPIController : ApiController
    {
        /// <summary>
        /// Receive input of temperature, provide message indicating season
        /// </summary>
        /// <param name="temperature">temperature in centigrade</param>
        /// <example>
        /// Get api/SeasonAPI/GetSeason/21 -> "summer"
        /// </example>
        /// <returns>
        /// The associated season with the temperature
        /// </returns>
        [Route("api/SeasonAPI/GetSeason/{temperature}")]
        public string GetSeason(int? temperature)
        {
            string season = "";
            if (temperature == null)
            {
                return "unknown";
            }

            if (temperature > 20)
            {
                season = "summer";
            }
            else if (temperature >= 15)
            {
                season = "fall";
            }
            else if (temperature > 10)
            {
                season = "spring";
            }
            else
            {
                season = "winter";
            }
            //string message = "The season is " + season + "!";
            return season;
        }
    }
}
