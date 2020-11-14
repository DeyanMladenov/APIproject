using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace APItesting.Models
{
    public class Link
    {


        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Href { get; set; }

        [JsonProperty("rel", NullValueHandling = NullValueHandling.Ignore)]
        public string Rel { get; set; }

        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public string Method { get; set; }


    }
}
