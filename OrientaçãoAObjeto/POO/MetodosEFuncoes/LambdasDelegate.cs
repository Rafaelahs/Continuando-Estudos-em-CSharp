using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoRafaela.MetodosEFuncoes
{
    delegate double operacao(double y, double x);
    
    
    
    
    
    class LambdasDelegate
    {
        public static void Executar()
        {
            operacao sum = ( y, x) => x + y;
            operacao sub = (x, y) => x - y;

            Console.WriteLine($"Somar {sum(3,3)}");
            Console.WriteLine($"Subtrair {sub(3, 6)}");


        }
    }
}
