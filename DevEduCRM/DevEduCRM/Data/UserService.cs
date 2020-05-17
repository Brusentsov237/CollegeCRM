
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DevEduCRM.Data.Models;
using DevEduCRM.RestApiInterfaces;
using Newtonsoft.Json;
using Refit;

namespace DevEduCRM.Data
{
    class UserService
    {
        private HttpClient _client;
        public UserService()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("http://80.78.240.16:5100/")
            };


        }

        public async Task<string> Auth(AuthModel model)
        {
            var content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8,
                "application/json");

            var response = await _client.PostAsync("/token", content);
            var stringContent = await response.Content.ReadAsStringAsync();
            var resultModel = JsonConvert.DeserializeObject<AuthResultModel>(stringContent);

            return resultModel.Token;
        }
    }
}
