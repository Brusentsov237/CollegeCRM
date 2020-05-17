using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DevEduCRM.Data.Models
{
    class AuthModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("login")]
        public string Login { get; set; }
    }
}
