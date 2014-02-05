using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using BitcoinWrapper.Data;
using BitcoinWrapper.Wrapper.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BitcoinWrapper.Wrapper
{
    public sealed class BaseConnector : IBaseConnector
    {
        private readonly String _serverIp = ConfigurationManager.AppSettings.Get("ServerIp");
        private readonly String _username = ConfigurationManager.AppSettings.Get("Username");
        private readonly String _password = ConfigurationManager.AppSettings.Get("Password");
        
        public BaseConnector()
        {
            if (String.IsNullOrWhiteSpace(_serverIp))
            {
                throw new ArgumentException("You have to add a server IP setting with key: ServerIp");
            }

            if (String.IsNullOrWhiteSpace(_username))
            {
                throw new ArgumentException("You have to add a bitcoin qt username setting with key: Username");
            }

            if (String.IsNullOrWhiteSpace(_password))
            {
                throw new ArgumentException("You have to add a bitcoin qt password setting with key: Password");
            }
        }

        public JObject RequestServer(MethodName methodName)
        {
            return RequestServer(methodName, parameters: null);
        }

        public JObject RequestServer(MethodName methodName, object parameter)
        {
            return RequestServer(methodName, new List<object> { parameter });
        }

        public JObject RequestServer(MethodName methodName, object parameter, object parameter2)
        {
            return RequestServer(methodName, new List<object> { parameter, parameter2 });
        }

        public JObject RequestServer(MethodName methodName, List<object> parameters)
        {
            HttpWebRequest rawRequest = GetRawRequest();

            //  basic info required by qt
            JObject jObject = new JObject
                {
                    new JProperty("jsonrpc", "1.0"),
                    new JProperty("id", "1"),
                    new JProperty("method", methodName.ToString())
                };

            //  adds provided parameters
            JArray props = new JArray();

            if (parameters != null && parameters.Any())
            {
                foreach (object parameter in parameters)
                {
                    props.Add(parameter);
                    
                }
            }

            StreamReader streamReader = null;
            jObject.Add(new JProperty("params", props));

            // serialize json for the request
            try
            {
                String s = JsonConvert.SerializeObject(jObject);
                byte[] byteArray = Encoding.UTF8.GetBytes(s);
                rawRequest.ContentLength = byteArray.Length;
                Stream dataStream = rawRequest.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                
                WebResponse webResponse = rawRequest.GetResponse();
                streamReader = new StreamReader(webResponse.GetResponseStream(), true);
                return (JObject)JsonConvert.DeserializeObject(streamReader.ReadToEnd());
            }
            catch (WebException webException)
            {
                if (webException.Status == WebExceptionStatus.ConnectFailure)
                {
                    throw new Exception("Could not connect to bitcoind, please check that bitcoind is up and running and that you configuration (" + _serverIp + ", " + _username + ", " + _password +") is correct");
                }
                return null;
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }

        private HttpWebRequest GetRawRequest()
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(_serverIp);
            webRequest.Credentials = new NetworkCredential(_username, _password);
            webRequest.ContentType = "application/json-rpc";
            webRequest.Method = "POST";
            return webRequest;
        }
    }
}
