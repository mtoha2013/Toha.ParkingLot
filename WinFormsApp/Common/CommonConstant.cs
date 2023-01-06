using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WinFormsApp.Common
{
    class CommonConstant
    {
        public static string ConnectionString { get; set; }
        public static int TotalParkSlot { get; set; }

        public static void ConfigureAppSettings()
        {

            string pathConfig = System.IO.Path.Combine(System.AppContext.BaseDirectory, "settings.json");
            if (File.Exists(pathConfig))
            {

                var json = System.IO.File.ReadAllText(pathConfig);
                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject<Newtonsoft.Json.Linq.JObject>(json);

                ConnectionString = (string)jsonObj["SQLConnectionString"];
                TotalParkSlot = jsonObj["TotalParkSlot"] == null ? 6 : (int)jsonObj["TotalParkSlot"];

            }
        }


        public static void UpdateParkAppSettings(string value)
        {

            string pathConfig = System.IO.Path.Combine(System.AppContext.BaseDirectory, "settings.json");
            if (File.Exists(pathConfig))
            {

                var json = System.IO.File.ReadAllText(pathConfig);
                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject<Newtonsoft.Json.Linq.JObject>(json);


                jsonObj["TotalParkSlot"] = value;

                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);

                System.IO.File.WriteAllText(pathConfig, output);

                TotalParkSlot = Convert.ToInt32(value);

            }
        }
    }
}
