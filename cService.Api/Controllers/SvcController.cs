using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using cModel;
using Newtonsoft.Json;

namespace cService.Api.Controllers
{
    //[HMACAuthentication]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SvcController : ApiController
    {
        /// <summary>
        /// Main API service
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<HttpResponseMessage> Post(HttpRequestMessage request)
        {
            try
            {
                //Deserialize param
                var jsonString = await request.Content.ReadAsStringAsync();
                if (String.IsNullOrEmpty(jsonString))
                    return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(new GCResponse
                    {
                        Result = 0,
                        Message = "Paramter is incorrect"
                    }));

                var obj = JsonConvert.DeserializeObject<GCRequest>(jsonString);
                var s = new S(ConfigurationManager.ConnectionStrings["cConStr"].ToString());
                var result = s.P(obj);
                return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(result));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(new GCResponse
                {
                    Result = 0,
                    Message = ex.Message
                }));
            }
        }
    }
}
