using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace ChuckNorrisJOTD
{
    public class Joke
    {
        public string id { get; set; }
        public string joke { get; set; }
        public string categories { get; set; }

    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// 
        
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ChuckNorris());

            
        }

        public static Joke GetRandomJoke()
        {
            Joke joke = new Joke();
            JArray getjokes = new JArray();

            using (var client = new WebClient())
            {

                client.BaseAddress = "http://api.icndb.com/jokes/random/";
                client.Headers.Add("Content-Type", "application/json");
                string response = "";
                try
                {
                    response = client.DownloadString(client.BaseAddress);
                }
                catch (Exception)
                {

                    throw;
                }
                response = "[" + response.Trim() + "]";
                getjokes = JArray.Parse(response);
                foreach (JObject obj in getjokes.Children<JObject>())
                {
                    foreach (JProperty singleProp in obj.Properties())
                    {
                        string name = singleProp.Name;
                        string value = singleProp.Value.ToString();

                        if (name == "value")
                        {
                            value = "[" + value.Trim() + "]";
                            JArray thejoke = JArray.Parse(value);
                            foreach (JObject obj1 in thejoke.Children<JObject>())
                            {
                                foreach (JProperty singleProp1 in obj1.Properties())
                                {
                                    string name1 = singleProp1.Name;
                                    string value1 = singleProp1.Value.ToString();
                                    if (name1 == "joke")
                                    {
                                        joke.joke = WebUtility.HtmlDecode(value1);
                                    }
                                }
                            }

                        }
                    }
                }
                return joke;
            }

        }

    }
}  

