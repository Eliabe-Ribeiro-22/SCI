using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio2
{
    public class Criptografia
    {
      
        //Método Criptografar com Hash MD5
        public string Criptografar(string senha)
        {
            MD5 hashMD5 = MD5.Create();
            byte[] valorCriptografado = hashMD5.ComputeHash(Encoding.Default.GetBytes(senha));

            StringBuilder strBuilder = new StringBuilder();

            for (int i = 0; i < valorCriptografado.Length; i++)
            {
                strBuilder.Append(valorCriptografado[i].ToString("x2"));
            }

            return strBuilder.ToString();

            //Método Criptografar com ASCII.
            /*
            byte[] senhaBinaria = ASCIIEncoding.ASCII.GetBytes(senha);

           string senhaCripto = Convert.ToBase64String(senhaBinaria);

            return senhaCripto; */
        }
/*
        public string Descriptografar(string senhaCripto)
        {
            byte[] senhaBinaria = Convert.FromBase64String(senhaCripto);

            string senhaDescripto = ASCIIEncoding.ASCII.GetString(senhaBinaria);

            return senhaDescripto;
        } */

    }
}
