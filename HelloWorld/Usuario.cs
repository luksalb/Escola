using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosPassos
{
    public class Usuario
    {
        public string Email;
        public string Senha;
        public string Nome;

        public Usuario()
        {

        }

        public virtual void Logar() // Método substituido na classe derivada
        {
            Console.WriteLine("O usuário logou.");
        }
    }
}
