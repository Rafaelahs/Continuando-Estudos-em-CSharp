using System;
using System.Linq;

namespace CursoRafaela.Excecoes
{
    class Class1
    {
        public static void Executar()
        {
            int[] vetor = new int[6];
            vetor[0] = 0;
            vetor[1] = 1;
            vetor[2] = 2;
            vetor[3] = 4;
            vetor[4] = 4;
           

            for (int i = 1; i < vetor.Length; i++)
            {
                for (int j = 1; j < vetor.Length; j++)
                {
                    if ( vetor[i] == vetor[j])
                    {
                        var f = vetor[j];
                        Console.WriteLine(f);

                        break;
                    }
                }
            }

        }
    }
}