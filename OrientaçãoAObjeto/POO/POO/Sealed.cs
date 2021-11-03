using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoRafaela.POO
{
    sealed class Semfilho {
        public double ValorDaFortuna()
        {
            return 1.800;
        }
    
    }

    class Avo
    {
        public virtual bool HonrarNomedaDaFamilia()
        {
            return true;
        }
    }

    class Pai : Avo
    {
        public sealed override bool HonrarNomedaDaFamilia()
        {
            return  true;
        }
    }

     class FilhoRebelde : Pai
    {
        //public override bool HonrarNomeDaFamilia()
    }



    class Sealed
    {
        public static void Executar()
        {
            var semFilho = new Semfilho();
            Console.WriteLine($"Sem filho: {semFilho.ValorDaFortuna()}");

            var rebelde = new FilhoRebelde();
            Console.WriteLine($"Filho Rebelde: {rebelde.HonrarNomedaDaFamilia()} ");

        }
    }
}
