using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DevEduCRM.Data.Models
{
    class AuthResultModel
    {
        [JsonProperty("access_token")]
        public string Token { get; set; }
        [JsonProperty("username")]
        public string Login { get; set; }
    }
}
