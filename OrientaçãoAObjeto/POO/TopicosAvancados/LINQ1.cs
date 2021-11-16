using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoRafaela.TopicosAvancados
{
   public class Aluno
    {
        public int Idade;
        public string Nome;
        public double Nota;
    }   
    
    class LINQ1
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>()
            {
                new Aluno() {Nome = "Rafaela", Idade = 17, Nota = 10 },
                new Aluno(){Nome = "Fernando", Idade = 12, Nota = 9},
                new Aluno(){Nome = "Maria", Idade = 15, Nota = 3},
                new Aluno() {Nome = "Yuri",  Idade = 16, Nota = 9 }
            };
            Console.WriteLine("=== Aprovados=========");
            var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nome);
            foreach(var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("==Chamadas====");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach(var aluno in chamada)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n== Aprovados (por idade)");
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;

            foreach ( var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno);
            }

        }
    }
}
