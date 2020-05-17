using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CompFixx.Models;

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
        public static void addText(string text)
        {
                       
            string path = @"C:\Users\Heric\source\repos\CompFixx\CompFixx\bin\Debug\Banco de Dados.txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(text);                
                
            }

            
        }
               
        public static void addint(int num)
        {

            string path = @"C:\Users\Heric\source\repos\CompFixx\CompFixx\bin\Debug\Banco de Dados.txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(num);

            }


        }
        public static void addbool(bool condicao)
        {

            string path = @"C:\Users\Heric\source\repos\CompFixx\CompFixx\bin\Debug\Banco de Dados.txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(condicao);

            }


        }

    }
}
