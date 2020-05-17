using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DevEduCRM.Data.Models.DTO
{
    class GroupModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("startDate")]
        public string StartDate { get; set; }
        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
        [JsonProperty("courseProgramId")]
        public int CourseProgramId { get; set; }
    }
}
