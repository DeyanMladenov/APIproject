namespace APItesting.Models
{

    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class CarsModel
    {

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }

        [JsonProperty("Engine", NullValueHandling = NullValueHandling.Ignore)]
        public long? Engine { get; set; }

        [JsonProperty("year", NullValueHandling = NullValueHandling.Ignore)]
        public long? Year { get; set; }

        [JsonProperty("horsePower", NullValueHandling = NullValueHandling.Ignore)]
        public long? HorsePower { get; set; }
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Link> Links { get; set; }
        public static CarsModel FromJson(string json) => JsonConvert.DeserializeObject<CarsModel>(json, APItesting.Models.Converter.Settings);

    }

}
