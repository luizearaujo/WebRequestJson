using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace WebRequestJson
{
    public class Client : IClient
    {
        public T Get<T>(string url)
        {
            var request = WebRequest.Create(url);

            var response = (HttpWebResponse)request.GetResponse();

            var dataStream = response.GetResponseStream();

            var reader = new StreamReader(dataStream);
            var data = reader.ReadToEnd();

            var _object = JsonConvert.DeserializeObject<T>(data);

            return _object;
        }
    }
}
