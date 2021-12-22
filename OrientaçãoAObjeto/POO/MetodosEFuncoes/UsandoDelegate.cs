using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoRafaela.MetodosEFuncoes
{
    class UsandoDelegate
     {
        delegate double Soma(double a, double b);
        delegate void  ImprimirSoma(double a, double y);

        static double MinhaSoma( double c, double e)
        {
            return e + c;
        }

        static void MeuImprimirSoma( double a, double b)
        {
            Console.WriteLine(a+b);
        }

               
        public static void Executar()
        {
            Soma som = MinhaSoma;
            ImprimirSoma impri = MeuImprimirSoma;

            Console.WriteLine(som(5,6));
            impri(5,6);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(3,6));

            Action<double, double> op4 = MeuImprimirSoma;
            op4(1, 1);


        } 
    }
}
 // Finalizado