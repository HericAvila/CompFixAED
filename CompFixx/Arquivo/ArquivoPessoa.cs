using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CompFixx.Arquivo
{
    class ArquivoPessoa
    {
        public static void criar() 
        {
            string path = @"C:\Users\Heric\source\repos\CompFixx\CompFixx\bin\Debug\Banco de Dados.txt";
            
            if (!File.Exists(path))
            {
                
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Dados do Cliente: ");

                }
            }

        }
        public static void addText()
        {
            string aux = Console.ReadLine();
            string path = @"C:\Users\Heric\source\repos\CompFixx\CompFixx\bin\Debug\Banco de Dados.txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(aux+"/n   ");                
                
            }

            
        }
            
    }
}
