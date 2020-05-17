using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DevEduCRM.Data.Models.DTO;
using DevEduCRM.RestApiInterfaces;
using Refit;

namespace DevEduCRM.DAL
{
    class GroupService
    {
        private HttpClient _client;
        private IGroupApi _httpGroupApi;
        private string _token;
        public GroupService(string token)
        {
            _token = token;
            _client = new HttpClient
            {
                BaseAddress = new Uri("http://80.78.240.16:5100/")
            };

            _httpGroupApi = RestService.For<IGroupApi>(_client);
        }

        public Task<List<GroupModel>> GetAllGroups()
        {
            return _httpGroupApi.GetAllGroups("Bearer " + _token);
        }

        public Task<GroupModel> GetGroupById()
        {
            return _httpGroupApi.GetGroupById("1303", "Bearer " + _token);
        }
    }
}
