using System;
using System.Text;

namespace Encryption_Login.Models
{
    public static class EncryptDecrypt
    {
        public static string MyKey ="saad@35sfsfz234";
        public static string ConvertToEncrypt(string password)
        {
          if(string.IsNullOrEmpty(password))
          return "";
          password += MyKey;
          var passwordBytes = Encoding.UTF8.GetBytes(password);
          return Convert.ToBase64String(passwordBytes);
        }

        public static string ConvertToDecrypt(string base64EncodeData)
        {
          if(string.IsNullOrEmpty(base64EncodeData))
          return "";
          var base64EncodeBytes = Convert.FromBase64String(base64EncodeData);
          var result = Encoding.UTF8.GetString(base64EncodeBytes);
          result = result.Substring(0, result.Length - MyKey.Length);
          return result;

        }
    }

}