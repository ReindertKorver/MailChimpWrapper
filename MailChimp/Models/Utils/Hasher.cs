using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace MailChimpWrapper.Models.Utils
{
    public static class Hasher
    {
        public static string CreateHash(string input)
        {
            MD5 hash = MD5.Create();
            var res = string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(input.ToLower())).Select(x => x.ToString("x2")));
            return res;
        }
    }
}