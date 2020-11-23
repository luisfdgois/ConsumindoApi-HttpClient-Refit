using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace TesteRequisitoApiNotifications.WebServices
{
    public class ResponseResult
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }
        [JsonProperty("result")]
        public string Result { get; set; }
    }
}
