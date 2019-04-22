using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EspaiActiu
{
    public class Encriptacion
    {


        static AesCryptoServiceProvider crypt_provider;

        public static void DemoAES()
        {
            crypt_provider = new AesCryptoServiceProvider();

            crypt_provider.BlockSize = 128;
            crypt_provider.KeySize = 256;
            crypt_provider.GenerateIV();
            crypt_provider.GenerateKey();
            crypt_provider.Mode = CipherMode.CBC;
            crypt_provider.Padding = PaddingMode.None;


        }

        public static String encrypt(String texto)
        {
            ICryptoTransform transform = crypt_provider.CreateEncryptor();

            byte[] encrypted_bytes = transform.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(texto), 0, texto.Length);

            string str = Convert.ToBase64String(encrypted_bytes);

            return str;
        }

        public static String decrypt(String texto)
        {
            ICryptoTransform transform = crypt_provider.CreateDecryptor();

            byte[] enc_bytes = Convert.FromBase64String(texto);

            byte[] decrypted_bytes = transform.TransformFinalBlock(enc_bytes, 0, enc_bytes.Length);

            string str = ASCIIEncoding.ASCII.GetString(decrypted_bytes);

            return str;

        }



    }
}
