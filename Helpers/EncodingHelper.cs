using System.Security.Cryptography;

namespace DataLayer.Libs.Helpers
{
    public class EncodingHelper
    {
        public static string EncodeHMACSHA1(string str, string key)
        {
            return EncodeHMACSHA1(System.Text.Encoding.UTF8.GetBytes(str), System.Text.Encoding.UTF8.GetBytes(key));
        }

        public static string EncodeHMACSHA1(byte[] str, byte[] key)
        {
            HMACSHA1 hmac = new HMACSHA1(key);
            return System.Text.Encoding.UTF8.GetString(hmac.ComputeHash(str));
        }
    }
}
