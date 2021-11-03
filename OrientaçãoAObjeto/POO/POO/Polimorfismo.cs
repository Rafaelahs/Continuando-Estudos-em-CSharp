using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoRafaela.POO
{
    public class Comida {
        public double Peso;

        public Comida(double peso)
        {
            Peso = peso;
        }

        public Comida() { }

    }

    public class Feijao : Comida
    {
        public Feijao(double peso) : base(peso) { }
    }

    public class Arroz : Comida { 
            public Arroz(double peso) : base(peso) { } 
    }

    public class Carne : Comida
    {
        public Carne(double peso) : base(peso) { }
    }

    public class Pessoa
    {
        public double peso;

        public void Comer(Comida comida) {
            peso += comida.Peso;
                }

    }





    public class Polimorfismo
    {
        public static void Executar()
        {
            Feijao ingrediente1 = new Feijao(0.96);
            Arroz ingrediente2 = new Arroz(0.88);
            Carne ingrediente = new Carne(0.96);

            Pessoa pessoa = new Pessoa();
            pessoa.peso = 80.0;
            pessoa.Comer(ingrediente);
            pessoa.Comer(ingrediente2);
            pessoa.Comer(ingrediente1); 
            Console.WriteLine($"Agora essa pessoa tem o peso de {pessoa.peso}");

        }

    }
}
