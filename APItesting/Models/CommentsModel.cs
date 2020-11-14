namespace APItesting.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class CommentsModel
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }

        [JsonProperty("postId", NullValueHandling = NullValueHandling.Ignore)]
        public long? PostId { get; set; }
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Link> Links { get; set; }
        public static CommentsModel FromJson(string json) => JsonConvert.DeserializeObject<CommentsModel>(json, APItesting.Models.Converter.Settings);

    }



}
