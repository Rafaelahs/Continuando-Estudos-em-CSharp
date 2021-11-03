﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoRafaela.POO
{
    public abstract class Celular
    {
        public abstract string Assistente();

        public string Tocar()
        {
            return "trim trim trim";
        }

    }

    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Olá, Meu nome é Bixby";
        }
    }


    public class Iphone : Celular
    {
        public override string Assistente()
        {
            return "Olá, Me chamo Siri";
        }
    }
    
    class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new Iphone(),
                new Samsung()
            };

            foreach ( var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
