using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Security
{
    public class Hashs
    {
        //Algoritmo para realizar o hash.
        private HashAlgorithm _algoritmo;

        public CriptografiaHash(HashAlgorithm algoritmo)
        {
            this._algoritmo = algoritmo;
        }

        public string getHash(string value)
        {
            //Pegar o array de bytes da string para poder passar 
            //para o método que calcula o hash.
            byte[] arrayValue = Encoding.ASCII.GetBytes(value);

            byte[] hashCalculado = _algoritmo.ComputeHash(arrayValue);

            StringBuilder montaResultado = new StringBuilder();

            foreach (var caractere in hashCalculado)
            {
                montaResultado.Append(caractere.ToString("X2"));
            }

            return montaResultado.ToString();
        }
    }
}
