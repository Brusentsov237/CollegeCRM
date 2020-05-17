using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DevEduCRM.Data.Models.DTO;
using Refit;

namespace DevEduCRM.RestApiInterfaces
{
    [Headers("Content-Type: application/json")]
    interface IGroupApi
    {
        [Get("/api/Group/get-all")]
        Task<List<GroupModel>> GetAllGroups([Header("Authorization")] string token);

        [Get("/api/Group/get/{id}")]
        Task<GroupModel> GetGroupById(string id, [Header("Authorization")] string token);
    }
}
