using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string res = GetString("https://localhost:44347/currencies");
        }

        static public string GetString(string requestUrl)
        {
            string res = string.Empty;

            try
            {
                using (var client = new HttpClient())
                {
                    res = client.GetAsync(requestUrl).Result.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            {

            }

            return res;
        }
    }
}
