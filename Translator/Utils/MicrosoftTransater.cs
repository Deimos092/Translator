using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net.Http;
using Translator.ViewModels;

namespace Translator.Utils
{
    class MicrosoftTransater
    {
        private string host = "https://api.cognitive.microsofttranslator.com";
        private string route = "/translate?api-version=3.0&to=en";
        private string subscriptionKey = "ddaa6e7133ab46b787092c45f059277f";

        public List<Items> Translate(object[] ObjectsBody)
        {
            var requestBody = JsonConvert.SerializeObject(ObjectsBody);
            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                // Set the method to POST
                request.Method = HttpMethod.Post;

                // Construct the full URI
                request.RequestUri = new Uri(host + route);

                // Add the serialized JSON object to your request
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

                // Add the authorization header
                request.Headers.Add("Ocp-Apim-Subscription-Key", subscriptionKey);

                // Send request, get response
                var response = client.SendAsync(request).Result;
                var jsonResponse = response.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject<List<Items>>(jsonResponse);
            }
        }   
    }
}
