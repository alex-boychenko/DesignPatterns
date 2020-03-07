using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class AuthToken
    {
        private string _appId;
        private string _key;

        public AuthToken(string appId, string key)
        {
            _appId = appId;
            _key = key;
        }
    }
}
