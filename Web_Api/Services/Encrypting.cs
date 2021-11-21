using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Api.Services
{
    public class Encrypting
    {
        string Key = "x@@lmnqwrst@";
        public string ConvertToEncrypt(string password)
        {
            if (string.IsNullOrEmpty(password)) 
                return null;
            password += Key;
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            return Convert.ToBase64String(passwordBytes);
        }
    }
}
