using Kentucky.Helper;
using Kentucky.iOS.Helper;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(CreateMD5))]
namespace Kentucky.iOS.Helper
{
    public class CreateMD5 : ICreateMD5
    {
        public string GenerateHash(string input)
        {
            MD5 md5Hash = MD5.Create();
            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Cria-se um StringBuilder para recompôr a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}
