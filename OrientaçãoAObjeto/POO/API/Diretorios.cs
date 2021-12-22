using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoRafaela.API
{
    class Diretorios
    {
        public static void Executar()
        {
            var novoDiretorio = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var DirProjeto =  @"~/source/repos/OrientaçãoAObjeto/POO".ParseHome();

            if (Directory.Exists(novoDiretorio))
            {
                Directory.Delete(novoDiretorio, true);
            }

            if (Directory.Exists(novoDirDestino))
            {
                
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDiretorio);
            Console.WriteLine(Directory.GetCreationTime(DirProjeto));

            Console.WriteLine("------- Pastas-----");

            var pastas = Directory.GetDirectories(DirProjeto);
            
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("-------arquivo-----");
            var arquivos = Directory.GetFiles(DirProjeto);
            foreach(var aquivo in arquivos)
            {
                Console.WriteLine(aquivo);
            }

            Console.WriteLine("-----Raiz----");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDiretorio));

            Directory.Move(novoDiretorio, novoDirDestino);

            //Finalizado

        }
    }
}
