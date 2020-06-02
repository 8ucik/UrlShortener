using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace UrlShortener.Apis
{
    class BitlyApi
    {
        public string ShrinkBitlyUrl(string strUrl)
        {
            var url = string.Format(Properties.Settings.Default.bitlyTokenUrl,
                Properties.Settings.Default.bitlyToken, HttpUtility.UrlEncode(strUrl));

            HttpWebRequest objWebRequest = (HttpWebRequest)WebRequest.Create(url);
            objWebRequest.Method = "GET";

            HttpWebResponse objWebResponse = (HttpWebResponse)objWebRequest.GetResponse();
            var streamReader = new StreamReader(objWebResponse.GetResponseStream(), Encoding.UTF8);
            var jsonResponse = JObject.Parse(streamReader.ReadToEnd());
            var statusCode = jsonResponse["status_code"].Value<int>();
            if (statusCode == (int)HttpStatusCode.OK)
                return jsonResponse["data"]["url"].Value<string>();

            streamReader.Close();
            objWebResponse.Close();
            objWebRequest.Abort();

            return jsonResponse["data"]["url"].Value<string>();
        }
    }
}
