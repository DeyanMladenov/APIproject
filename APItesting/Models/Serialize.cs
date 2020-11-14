using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace APItesting.Models
{
    public static class Serialize
    {
        public static string ToJson(this PostsModel self) => JsonConvert.SerializeObject(self, APItesting.Models.Converter.Settings);
        public static string ToJson(this CommentsModel self) => JsonConvert.SerializeObject(self, APItesting.Models.Converter.Settings);
        public static string ToJson(this UsersModel self) => JsonConvert.SerializeObject(self, APItesting.Models.Converter.Settings);
        public static string ToJson(this CarsModel self) => JsonConvert.SerializeObject(self, APItesting.Models.Converter.Settings);

    }

}
