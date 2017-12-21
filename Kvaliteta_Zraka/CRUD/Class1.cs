using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Configuration;
using Newtonsoft.Json.Linq;
using System.Data.SqlClient;
using System.Data.Common;

namespace CRUD
{
    public class Class_CRUD
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
            List<MeasurementStation> lMeasurementStations = new List<MeasurementStation>();
            String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "SELECT * FROM AirQuality_measurement_stations";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        lMeasurementStations.Add(new MeasurementStation
                        {
                            MEASUREMENT_STATION_ID = (int)oReader["ID"],
                            MEASUREMENT_STATION_NAME = (string)oReader["NAME"]
                        });
                    }
                    return lMeasurementStations;
                }
            }
        }
        

        public List<Pollutants> GetAllPollutants()
        {
            List<Pollutants> lPollutants = new List<Pollutants>();
            String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "SELECT * FROM AirQuality_pollutants";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        lPollutants.Add(new Pollutants()
                        {
                            POLLUTANT_ID = (int)oReader["ID"],
                            POLLUTANT_NAME = (string)oReader["NAME"]
                        });
                    }
                }
            }
            return lPollutants;
        }
    }
}

/*kreirati link i prikazati rezultate u datagridview*/
/*tip podatka samo dnevni validirani podaci*/