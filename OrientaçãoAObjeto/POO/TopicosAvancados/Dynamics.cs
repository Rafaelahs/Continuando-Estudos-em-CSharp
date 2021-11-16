using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoRafaela.TopicosAvancados
{
    class Dynamics
    {
        public static void Executar()
        {
            dynamic meuObjeto = "Teste";
            meuObjeto = 3;
            meuObjeto++;
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Rafaela";
            aluno.nota = 9.8;
            aluno.idade = 17;
            Console.WriteLine($"Nome: {aluno.nome} Nota: {aluno.nota} Idade: {aluno.idade}");

        }
    }
}
