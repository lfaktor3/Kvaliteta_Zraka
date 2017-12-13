using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Kvaliteta_Zraka;
using System.Configuration;

namespace Kvaliteta_Zraka
{
    public class CRUD
    {
        public static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }
        
        

        public List<MeasurementStation> GetAllMeasurementStations()
        {
            List<MeasurementStation> lRESTMeasurementStation = new List<MeasurementStation>();
            string sUrl = System.Configuration.ConfigurationManager.AppSettings["RestApiUrl"];
            string sJson = CallRestMethod(sUrl);
            JObject oJson = JObject.Parse(sJson);
            var oStations = oJson["resources"].ToList();
            for (int i = 0; i < oStations.Count; i++)
            {
                lRESTMeasurementStation.Add(new MeasurementStation
                {
                    MEASUREMENT_STATION_ID = (int)oStations[i]["id"],
                    MEASUREMENT_STATION_NAME = (string)oStations[i]["name"],
                });
            }
            return lRESTMeasurementStation;
        }
        public List<Pollutant> GetAllPollutants()
        {
            List<Pollutant> lRESTPollutant = new List<Pollutant>();
            string sUrl = System.Configuration.ConfigurationManager.AppSettings["RestApiUrl"];
            string sJson = CallRestMethod(sUrl);
            JObject oJson = JObject.Parse(sJson);
            var oPollutants = oJson["resources"].ToList();
            for (int i = 0; i < oPollutants.Count; i++)
            {
                lRESTPollutant.Add(new Pollutant
                {
                    POLLUTANT_ID = (int)oPollutants[i]["id"],
                    POLLUTANT_NAME = (string)oPollutants[i]["name"],
                });
            }
            return lRESTPollutant;
        }
    }
}