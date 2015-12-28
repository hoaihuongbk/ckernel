using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cService.Api.Demo
{
    class Program
    {
        static void Main()
        {
            GenerateKeyDemo();
            //RunAsync().Wait();
        }

        public static void GenerateKeyDemo()
        {
            //using (var cryptoProvider = new RNGCryptoServiceProvider())
            //{
            //    var secretKeyByteArray = new byte[32]; //256 bit
            //    cryptoProvider.GetBytes(secretKeyByteArray);
            //    var apiKey = Convert.ToBase64String(secretKeyByteArray);
            //    Console.WriteLine(Guid.NewGuid().ToString("N"));
            //    Console.WriteLine(apiKey);
            //}
            //Console.ReadLine();
            RunAsync().Wait();
        }


        static async Task RunAsync()
        {

            Console.WriteLine("Calling the back-end API");

            const string apiBaseAddress = "http://localhost/capi/";

            var customDelegatingHandler = new CustomDelegatingHandler();

            var client = HttpClientFactory.Create(customDelegatingHandler);
            //var client = new HttpClient();

            //var order = new Order { OrderID = 10248, CustomerName = "Taiseer Joudeh", ShipperCity = "Amman", IsShipped = true };
            var obj = new Dictionary<string, object>
            {
                {"_a", "fGetgc_App"},
                {"_c", new Dictionary<string, object>
                {
                    {"Id", 11}
                }}
            };

            var response = await client.PostAsJsonAsync(apiBaseAddress + "api/svc", obj);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);
                Console.WriteLine("HTTP Status: {0}, Reason {1}. Press ENTER to exit", response.StatusCode, response.ReasonPhrase);
            }
            else
            {
                Console.WriteLine("Failed to call the API. HTTP Status: {0}, Reason {1}", response.StatusCode, response.ReasonPhrase);
            }

            Console.ReadLine();
        }

        public class CustomDelegatingHandler : DelegatingHandler
        {
            //Obtained from the server earlier, APIKey MUST be stored securly and in App.Config
            private const string AppId = "4d53bce03ec34c0a911182d4c228ee6c";
            private const string ApiKey = "A93reRTUJHsCuQSHR+L3GxqOJyDmQpCgps102ciuabc=";

            protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                var requestContentBase64String = string.Empty;

                var requestUri = System.Web.HttpUtility.UrlEncode(request.RequestUri.AbsoluteUri.ToLower());

                var requestHttpMethod = request.Method.Method;

                //Calculate UNIX time
                var epochStart = new DateTime(1970, 01, 01, 0, 0, 0, 0, DateTimeKind.Utc);
                var timeSpan = DateTime.UtcNow - epochStart;
                var requestTimeStamp = Convert.ToUInt64(timeSpan.TotalSeconds).ToString(CultureInfo.InvariantCulture);

                //create random nonce for each request
                var nonce = Guid.NewGuid().ToString("N");

                //Checking if the request contains body, usually will be null wiht HTTP GET and DELETE
                if (request.Content != null)
                {
                    var content = await request.Content.ReadAsByteArrayAsync();
                    var md5 = MD5.Create();
                    //Hashing the request body, any change in request body will result in different hash, we'll incure message integrity
                    var requestContentHash = md5.ComputeHash(content);
                    requestContentBase64String = Convert.ToBase64String(requestContentHash);
                }

                //Creating the raw signature string
                var signatureRawData = String.Format("{0}{1}{2}{3}{4}{5}", AppId, requestHttpMethod, requestUri, requestTimeStamp, nonce, requestContentBase64String);

                var secretKeyByteArray = Convert.FromBase64String(ApiKey);

                var signature = Encoding.UTF8.GetBytes(signatureRawData);

                using (var hmac = new HMACSHA256(secretKeyByteArray))
                {
                    var signatureBytes = hmac.ComputeHash(signature);
                    var requestSignatureBase64String = Convert.ToBase64String(signatureBytes);
                    //Setting the values in the Authorization header using custom scheme (amx)
                    request.Headers.Authorization = new AuthenticationHeaderValue("amx", string.Format("{0}:{1}:{2}:{3}", AppId, requestSignatureBase64String, nonce, requestTimeStamp));
                }

                var response = await base.SendAsync(request, cancellationToken);

                return response;
            }
        }
    }
}
