using System;
using System.Collections.Generic;
using System.Text;

namespace DevEduCRM.Interfaces
{
    public interface ITokenManager
    {
        void SetToken(string token);
        string GetToken();
    }
}
