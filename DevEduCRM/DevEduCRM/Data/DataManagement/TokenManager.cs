using System;
using System.Collections.Generic;
using System.Text;
using DevEduCRM.Interfaces;

namespace DevEduCRM.Data.DataManagement
{
    class TokenManager : ITokenManager
    {
        private string _token;
        public void SetToken(string token)
        {
            _token = token;
        }

        public string GetToken()
        {
            return _token;
        }
    }
}
