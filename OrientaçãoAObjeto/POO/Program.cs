using CursoRafaela.POO;
using CursoRafaela.MetodosEFuncoes;
using CursoRafaela.Excecoes;
using CursoRafaela.API;
using CursoRafaela.TopicosAvancados;
using System;


namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polimorfismo...");
            Polimorfismo.Executar();
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("Classe Abstrata...");
            Abstract.Executar();
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("Interface");
            Interteface.Executar();
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("Sealed");
            Sealed.Executar();

            // Métodos e Funções

            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("Exemplo Lambda");
            ExempoLambda.Executar();
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("Delegate com Lambda");
            LambdasDelegate.Executar();
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("Usando Delegate");
            UsandoDelegate.Executar();
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("Delegate Função Anonima");
            DelegateFunAnonima.Executar();
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("Delegate Como Parametros");
            DelegatesComoParametros.Executar();
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("Métodos de Extensão");
            MetodosDeExtensao.Executar();

            //Exceções
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("Primeira Excecao");
            PrimeiraExcecao.Executar();
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("Exceções Personalizadas");
            ExecoesPersonalizadas.Executar();
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("-------------| | ------------");
            Class1.Executar();

            // Um pouco de API
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("Usando API");
            PrimeiroArquivo.Executar();
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("Lendo Arquivo");
            LendoArquivos.Executar();
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("Exemplo de FileInfo");
            ExemploFileInfo.Executar();
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("Diretórios");
            Diretorios.Executar();
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("Exemplo DirectoryInfo");
            ExemploDirectoryInfo.Executar();
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("Exemplo Path");
            ExemploPath.Executar();
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("Exemplo DateTime");
            ExemploDateTime.Executar();
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("Exemplo TimerSpan");
            ExemploTimeSpan.Executar();

            //Tópicos Avançados
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine(" LINQ #01");
            LINQ1.Executar();
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("LINQ #02");
            LINQ2.Executar();
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("Nullables");
            Nullables.Executar();
            Console.WriteLine("-------------| | ------------");
            Console.WriteLine("Dynamics");
            Dynamics.Executar();




        }
    }
}
