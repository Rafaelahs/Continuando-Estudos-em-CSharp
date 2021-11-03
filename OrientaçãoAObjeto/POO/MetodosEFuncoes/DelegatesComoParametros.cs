using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoRafaela.MetodosEFuncoes
{
    class DelegatesComoParametros
    {
        public delegate int Operacao(int x, int y);
        
        public static int Soma(int x, int y)
        {
            return x + y;
        }

        public static string Calculadora( Operacao op, int y, int x)
        {
            var resultado = op(x, y);
            return "Resultado:" + resultado;
        }       
        public static void Executar()
        {
            Operacao subtracao = (int y, int x) => x - y;
            Operacao multi = (int y, int x) => x * y;
            Console.WriteLine($"Subtração: {Calculadora(subtracao,6,3)}");
            Console.WriteLine($"Multipicação: {Calculadora(multi,3,3)}");

            Console.WriteLine($"Soma: {Calculadora(Soma,2,2)}");
        }
    }
}
