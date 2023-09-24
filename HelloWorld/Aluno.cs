using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosPassos
{
    public class Aluno : Usuario
    {
        public int Matricula;
        public decimal Media { get; private set; }
        private List<Materia> Materias;

        public Aluno() // Poderia ser utilizado o base para reutilizar código da classe Usuario e passar o Materias acima para dentro dos colchetes.
        { }

        public Aluno(string nome)
        {
            Nome = nome;
        }

        public void CalcularMedia(decimal nota1, decimal nota2, decimal nota3) // utiliza-se void quando não queremos que tenham retorno
        {
            decimal total = nota1 + nota2 + nota3;
            Media = total / 3;
        }

        public string AdicionarMateria(Materia materia)
        {
            foreach (Materia mate in Materias)
            {
                if (mate.Nome == materia.Nome)
                    return "Esta matéria já existe.";
            }

            Materias.Add(materia);
            return "Matéria adicionada com suceso.";
        }
        public override void Logar()
        {
            Console.WriteLine("O aluno logou");
        }

    }
}
