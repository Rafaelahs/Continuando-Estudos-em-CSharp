using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoRafaela.MetodosEFuncoes
{
    class DelegateFunAnonima
    {
        delegate string StringOperacao(string s);

        public static void Executar()
        {
            StringOperacao inverte = delegate (String s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

            Console.WriteLine(inverte("reverter frase!"));

        }
    }
}
