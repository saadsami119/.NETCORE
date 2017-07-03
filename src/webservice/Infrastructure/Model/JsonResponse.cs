using Newtonsoft.Json;

namespace webservice.Infrastructure.Model
{
    public class JsonResponse
    {
        [JsonProperty(PropertyName = "successful")]
        public bool Successful { get; set; }

        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }

        [JsonProperty(PropertyName = "data")]
        public object Data { get; set; }

    }
}