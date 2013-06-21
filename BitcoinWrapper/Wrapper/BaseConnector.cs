using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BitcoinWrapper.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BitcoinWrapper.Wrapper
{
    public class BaseConnector
    {
        private string serverIp = ConfigurationManager.AppSettings.Get("serverip");
        private string username = ConfigurationManager.AppSettings.Get("username");
        private string password = ConfigurationManager.AppSettings.Get("password");


        public BaseConnector()
        {
            if (string.IsNullOrEmpty(serverIp))
            {
                throw new ArgumentException("You have to add a server IP setting with key: serverip");
            }
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("You have to add a bitcoin qt username setting with key: username");
            }
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("You have to add a bitcoin qt password setting with key: password");
            }
        }

        public JObject RequestServer(MethodName methodName)
        {
            return RequestServer(methodName, null);
        }


        public JObject RequestServer(MethodName methodName, List<string> parameters)
        {
            var rawRequest = GetRawRequest();

            // basic required info to qt
            JObject joe = new JObject();
            joe.Add(new JProperty("jsonrpc", "1.0"));
            joe.Add(new JProperty("id", "1"));
            joe.Add(new JProperty("method", methodName.ToString()));

            // adds provided paramters

            JArray props = new JArray();
            if (parameters != null && parameters.Any())
            {
                
                foreach (var parameter in parameters)
                {
                    props.Add(parameter);
                }

    
            }
            joe.Add(new JProperty("params", props));            
            
            // serialize json for the request
            string s = JsonConvert.SerializeObject(joe);
            byte[] byteArray = Encoding.UTF8.GetBytes(s);
            rawRequest.ContentLength = byteArray.Length;
            Stream dataStream = rawRequest.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            StreamReader streamReader = null;
            try
            {
                WebResponse webResponse = rawRequest.GetResponse();

                streamReader = new StreamReader(webResponse.GetResponseStream(), true);

                return (JObject)JsonConvert.DeserializeObject(streamReader.ReadToEnd());
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }

            }
            return null;
        }

        private HttpWebRequest GetRawRequest()
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(serverIp);
            webRequest.Credentials = new NetworkCredential(username, password);

            webRequest.ContentType = "application/json-rpc";
            webRequest.Method = "POST";

            return webRequest;
        }
    }
}
