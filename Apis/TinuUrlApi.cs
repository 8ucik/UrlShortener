using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UrlShortener.Apis
{
    class TinuUrlApi
    {
        public string ShrinkTinyUrl(string strUrl)
        {
            string url = "http://tinyurl.com/api-create.php?url=" + strUrl.ToLower();

            HttpWebRequest objWebRequest = (HttpWebRequest)WebRequest.Create(url);
            objWebRequest.Method = "GET";

            HttpWebResponse objWebResponse = (HttpWebResponse)objWebRequest.GetResponse();
            var streamReader = new StreamReader(objWebResponse.GetResponseStream());

            var strHtml = streamReader.ReadToEnd();

            streamReader.Close();
            objWebResponse.Close();
            objWebRequest.Abort();

            return strHtml;
        }
    }
}
