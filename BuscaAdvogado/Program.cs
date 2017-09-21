using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * http://www.cnj.jus.br/poder-judiciario/portais-dos-tribunais
 * http://cna.oab.org.br/
 * 
 * 
 */

namespace BuscaAdvogado
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Advogado> advogados = new List<Advogado>();

            StreamReader file = new StreamReader("nomes.txt");
            String line;
            while((line = file.ReadLine()) != null)
            {
                Advogado adv = new Advogado(line);

                //adicionar inscricoes
                Process myProcess = new Process();
                myProcess.StartInfo.FileName = "http://cna.oab.org.br/";
                myProcess.WaitForExit();
                //Process.Start("http://cna.oab.org.br/");

                //verificar inscricoes nos tribunais

                advogados.Add(adv);
            }
            file.Close();

        }
    }
}
